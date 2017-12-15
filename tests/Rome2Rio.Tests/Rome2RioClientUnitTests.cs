namespace Rome2RioTests {

    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Rome2Rio;
    using Rome2Rio.Data;
    using System.Threading.Tasks;

    [TestClass]
    public class Rome2RioClientUnitTests {
        [TestMethod]
        public async Task SearchMethodTest() {
            var client = new Rome2RioClient("free.rome2rio.com", "qLPLy3g8", ContentType.JSON);
            var result = await client.SearchAsync("Ostrava", "Bordeaux", null, null, PlaceKind.City, PlaceKind.City, "CZK", "EN", SearchOptions.All, "Výsledek hledání při testování");
        }

        [TestMethod]
        public async Task AutocompleteMethodTest() {
            var client = new Rome2RioClient("free.rome2rio.com", "qLPLy3g8", ContentType.JSON);
            var result = await client.AutocompleteAsync("Ostrav", "CZK", "EN");
        }

        [TestMethod]
        public async Task GeocodeMethodTest() {
            var client = new Rome2RioClient("free.rome2rio.com", "qLPLy3g8", ContentType.JSON);
            var result = await client.GeocodeAsync("Ostrava", "CZK", "EN");
        }
    }
}
