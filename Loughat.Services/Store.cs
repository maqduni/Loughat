using Raven.Client.Documents;
using System;
using System.Collections.Generic;
using System.Text;
using Loughat.Services.Indexes;

namespace Loughat.Services
{
    public class Store
    {
        private static readonly Lazy<IDocumentStore> documentStore = new Lazy<IDocumentStore>(CreateDocumentStore);

        public static IDocumentStore Documents => documentStore.Value;

        private static IDocumentStore CreateDocumentStore()
        {
            IDocumentStore store = new DocumentStore()
            {
                Urls = new string[] { "http://localhost:8080" },
                Database = "Loughat"
            }
            .Initialize();

            return store;
        }

        public static void Dispose()
        {
            Documents.Dispose();
        }

        public static void ExecuteIndexCreationTasks()
        {
            // TODO: Make it generic to execute all indexes in the namespace
            new Cards_Search().Execute(Documents);
        }
    }
}
