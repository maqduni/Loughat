using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Loughat.Entities;
using Microsoft.Extensions.Logging;
using Raven.Client.Documents;
using Loughat.Entities.Enums;
using Loughat.Services.Indexes;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Loughat.Controllers
{
    /// <summary>
    /// Processes word realted requests
    /// </summary>
    [Route("api/[controller]")]
    public class CardsController : Controller
    {
        // TODO: Should I go fully RESTful?
        private readonly ILogger<CardsController> _logger;
        private readonly IDocumentStore _store;

        /// <summary>
        /// Controller constructor, receives and binds injected services
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="store"></param>
        public CardsController(ILogger<CardsController> logger, IDocumentStore store)
        {
            _logger = logger;
            _store = store;
        }

        /// <summary>
        /// Get cards in paged fashion
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Card> Get(string query, string word, int page = 1, int page_size = 10)
        {
            using (var session = _store.OpenAsyncSession())
            {
                //var dbQuery = session.Query<Cards_Search.QueryProjection, Cards_Search>();
                var dbQuery = session.Advanced.AsyncDocumentQuery<Cards_Search.Result, Cards_Search>();

                // Apply search terms
                if (!string.IsNullOrWhiteSpace(query))
                {
                    //dbQuery.Search(x => x.Query, query, 1, SearchOptions.And, EscapeQueryOptions.RawQuery);
                    dbQuery.Search("Query", query, EscapeQueryOptions.EscapeAll);
                }
                else if (!string.IsNullOrWhiteSpace(word))
                {
                    // TODO: RavenDB allows to search by using such queries but you have to be aware that leading wildcards drastically slow down searches.
                    // Consider if you really need to find substrings, most cases looking for words is enough.There are also other alternatives for 
                    // searching without expensive wildcard matches, e.g.indexing a reversed version of text field or creating a custom analyzer.

                    //dbQuery.Where(x => x.Word.Equals($"*{word}*"));
                    dbQuery.Where($"Word:*{word}*");
                }
                
                // Don't return anything if no terms where specified
                if (string.IsNullOrWhiteSpace(dbQuery.ToString()))
                {
                    return new List<Card>();
                }

                // Apply paging
                dbQuery.Skip((page - 1) * page_size).Take(page_size);

                var results = dbQuery.OfType<Card>().ToListAsync().Result;
                return results;
            }

            //http://www.davejsaunders.com/2015/04/26/paging-in-restful-web-services.html
            //The most common way to do this is with a custom HTTP response header(for example X-Total-Count).
        }

        /// <summary>
        /// Get the card by unique id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Card Get(string id)
        {
            return null;
        }

        /// <summary>
        /// Create new card
        /// </summary>
        /// <param name="card"></param>
        [HttpPost]
        public void Post(Card card)
        {
            // TODO: Validate the card

            // TODO: Store in the db

            // TODO: Log the activity
        }

        /// <summary>
        /// Update a card
        /// </summary>
        /// <param name="id"></param>
        /// <param name="card"></param>
        [HttpPut("{id}")]
        public void Put(int id, Card card)
        {
            // TODO: Validate

            // TODO: Save changes

            // TODO: Log the activity
        }

        /// <summary>
        /// Delete a card
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
