using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Loughat.Entities;
using Microsoft.Extensions.Logging;

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

        /// <summary>
        /// Controller constructor, receives and binds injected services
        /// </summary>
        /// <param name="logger"></param>
        public CardsController(ILogger<CardsController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get cards in paged fashion
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Card> Get()
        {
            throw new NotImplementedException();
            return null;
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
