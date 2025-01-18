using CompreseCodeHumffman;

namespace AlgoritmCodeHuffman_
{
    public class CodeHumffmanTests
    {
        const string word = "abracadabra";

        [Fact]
        public void FrequencySheetTest()
        {
            var frequencySheet = new FrequencySheets();
            var numberA = frequencySheet.CreateListWeightBySymbol(word);
            var widths = new Dictionary<char, int>
            {
                { 'a', 5 },
                { 'b', 2 },
                { 'r', 2 },
                { 'c', 1 },
                { 'd', 1 }
            };

            Assert.Equal(widths, numberA);
        }

        [Fact]
        public void NodeTest()
        {
            var frequencySheet = new FrequencySheets();
            var numberA = frequencySheet.CreateListWeightBySymbol(word);
            var node = frequencySheet.CreateNode(numberA);
            var widths = new Dictionary<char, int>
            {
                { 'a', 5 },
                { 'b', 2 },
                { 'r', 2 },
                { 'c', 1 },
                { 'd', 1 }
            };

            var ex = widths.Select(x => new Node(x.Value, x.Key.ToString()));

            foreach (var item in ex)
            {
                Assert.Contains(node, x => x.Value == item.Value);
            }

        }

        [Fact]
        public void HumffmanCodeTest()
        {
            var frequencySheet = new FrequencySheets();
            var codeHumffman = new HumffmanCode();

            var numberA = frequencySheet.CreateListWeightBySymbol(word);
            var node = frequencySheet.CreateNode(numberA);

            codeHumffman.TreeCode(node);
        }

        [Fact]
        public void CodeTest()
        {
            var frequencySheet = new FrequencySheets();
            var codeHumffman = new HumffmanCode();

            var numberA = frequencySheet.CreateListWeightBySymbol(word);
            var node = frequencySheet.CreateNode(numberA);
            var tree = codeHumffman.TreeCode(node);
            var codeDic = new Dictionary<string, string>();

            codeHumffman.Code(tree, codeDic);
            var exDic = new Dictionary<string, string>
            {
                { "a", "0" },
                { "b", "11" },
                { "r", "101" },
                { "c", "1000" },
                { "d", "1001" }
            };

            Assert.Equal(exDic, codeDic);
        }

    }
}