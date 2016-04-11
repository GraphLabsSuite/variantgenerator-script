using GraphLabs.Graphs;
using GraphLabs.Graphs.DataTransferObjects.Converters;
using variantgenerator_script.ServiceReference;

namespace variantgenerator_script
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Подграфы
            #region #1 - 11
            var debugGraph1 = UndirectedGraph.CreateEmpty(5);
            debugGraph1.AddEdge(new UndirectedEdge(debugGraph1.Vertices[2], debugGraph1.Vertices[0]));
            debugGraph1.AddEdge(new UndirectedEdge(debugGraph1.Vertices[0], debugGraph1.Vertices[3]));
            debugGraph1.AddEdge(new UndirectedEdge(debugGraph1.Vertices[0], debugGraph1.Vertices[4]));
            debugGraph1.AddEdge(new UndirectedEdge(debugGraph1.Vertices[1], debugGraph1.Vertices[4]));
            debugGraph1.AddEdge(new UndirectedEdge(debugGraph1.Vertices[3], debugGraph1.Vertices[1]));
            #endregion
            #region #2 - 11
            var debugGraph2 = UndirectedGraph.CreateEmpty(5);
            debugGraph2.AddEdge(new UndirectedEdge(debugGraph2.Vertices[0], debugGraph2.Vertices[1]));
            debugGraph2.AddEdge(new UndirectedEdge(debugGraph2.Vertices[0], debugGraph2.Vertices[3]));
            debugGraph2.AddEdge(new UndirectedEdge(debugGraph2.Vertices[0], debugGraph2.Vertices[4]));
            debugGraph2.AddEdge(new UndirectedEdge(debugGraph2.Vertices[1], debugGraph2.Vertices[4]));
            debugGraph2.AddEdge(new UndirectedEdge(debugGraph2.Vertices[3], debugGraph2.Vertices[4]));
            #endregion
            #region #3 - 10
            var debugGraph3 = UndirectedGraph.CreateEmpty(5);
            debugGraph3.AddEdge(new UndirectedEdge(debugGraph3.Vertices[0], debugGraph3.Vertices[1]));
            debugGraph3.AddEdge(new UndirectedEdge(debugGraph3.Vertices[0], debugGraph3.Vertices[3]));
            debugGraph3.AddEdge(new UndirectedEdge(debugGraph3.Vertices[0], debugGraph3.Vertices[4]));
            #endregion
            #region #4 - 16
            var debugGraph4 = UndirectedGraph.CreateEmpty(6);
            debugGraph4.AddEdge(new UndirectedEdge(debugGraph4.Vertices[0], debugGraph4.Vertices[1]));
            debugGraph4.AddEdge(new UndirectedEdge(debugGraph4.Vertices[0], debugGraph4.Vertices[3]));
            debugGraph4.AddEdge(new UndirectedEdge(debugGraph4.Vertices[0], debugGraph4.Vertices[4]));
            debugGraph4.AddEdge(new UndirectedEdge(debugGraph4.Vertices[0], debugGraph4.Vertices[5]));
            debugGraph4.AddEdge(new UndirectedEdge(debugGraph4.Vertices[1], debugGraph4.Vertices[2]));
            debugGraph4.AddEdge(new UndirectedEdge(debugGraph4.Vertices[1], debugGraph4.Vertices[3]));
            debugGraph4.AddEdge(new UndirectedEdge(debugGraph4.Vertices[1], debugGraph4.Vertices[5]));
            debugGraph4.AddEdge(new UndirectedEdge(debugGraph4.Vertices[2], debugGraph4.Vertices[3]));
            debugGraph4.AddEdge(new UndirectedEdge(debugGraph4.Vertices[2], debugGraph4.Vertices[5]));
            debugGraph4.AddEdge(new UndirectedEdge(debugGraph4.Vertices[3], debugGraph4.Vertices[5]));
            #endregion
            #region #5 - 11
            var debugGraph5 = UndirectedGraph.CreateEmpty(5);
            debugGraph5.AddEdge(new UndirectedEdge(debugGraph5.Vertices[0], debugGraph5.Vertices[1]));
            debugGraph5.AddEdge(new UndirectedEdge(debugGraph5.Vertices[0], debugGraph5.Vertices[3]));
            debugGraph5.AddEdge(new UndirectedEdge(debugGraph5.Vertices[0], debugGraph5.Vertices[4]));
            debugGraph5.AddEdge(new UndirectedEdge(debugGraph5.Vertices[1], debugGraph5.Vertices[4]));
            debugGraph5.AddEdge(new UndirectedEdge(debugGraph5.Vertices[2], debugGraph5.Vertices[4]));
            #endregion
            #endregion
            #region Изоморфизм
            #region Группа 1-2
            var graph1 = UndirectedGraph.CreateEmpty(6);
            graph1.AddEdge(new UndirectedEdge(graph1.Vertices[0], graph1.Vertices[1]));
            graph1.AddEdge(new UndirectedEdge(graph1.Vertices[0], graph1.Vertices[2]));
            graph1.AddEdge(new UndirectedEdge(graph1.Vertices[0], graph1.Vertices[5]));
            graph1.AddEdge(new UndirectedEdge(graph1.Vertices[1], graph1.Vertices[2]));
            graph1.AddEdge(new UndirectedEdge(graph1.Vertices[1], graph1.Vertices[3]));
            graph1.AddEdge(new UndirectedEdge(graph1.Vertices[2], graph1.Vertices[3]));
            graph1.AddEdge(new UndirectedEdge(graph1.Vertices[2], graph1.Vertices[4]));
            graph1.AddEdge(new UndirectedEdge(graph1.Vertices[3], graph1.Vertices[4]));
            graph1.AddEdge(new UndirectedEdge(graph1.Vertices[3], graph1.Vertices[5]));
            graph1.AddEdge(new UndirectedEdge(graph1.Vertices[4], graph1.Vertices[5]));
            var graph2 = UndirectedGraph.CreateEmpty(6);
            graph2.AddEdge(new UndirectedEdge(graph2.Vertices[3], graph2.Vertices[2]));
            graph2.AddEdge(new UndirectedEdge(graph2.Vertices[3], graph2.Vertices[1]));
            graph2.AddEdge(new UndirectedEdge(graph2.Vertices[3], graph2.Vertices[0]));
            graph2.AddEdge(new UndirectedEdge(graph2.Vertices[2], graph2.Vertices[1]));
            graph2.AddEdge(new UndirectedEdge(graph2.Vertices[2], graph2.Vertices[4]));
            graph2.AddEdge(new UndirectedEdge(graph2.Vertices[1], graph2.Vertices[4]));
            graph2.AddEdge(new UndirectedEdge(graph2.Vertices[1], graph2.Vertices[5]));
            graph2.AddEdge(new UndirectedEdge(graph2.Vertices[4], graph2.Vertices[5]));
            graph2.AddEdge(new UndirectedEdge(graph2.Vertices[4], graph2.Vertices[0]));
            graph2.AddEdge(new UndirectedEdge(graph2.Vertices[5], graph2.Vertices[0]));
            #endregion
            #region Группа 3-5
            var graph3 = UndirectedGraph.CreateEmpty(7);
            graph3.AddEdge(new UndirectedEdge(graph3.Vertices[0], graph3.Vertices[1]));
            graph3.AddEdge(new UndirectedEdge(graph3.Vertices[0], graph3.Vertices[2]));
            graph3.AddEdge(new UndirectedEdge(graph3.Vertices[0], graph3.Vertices[5]));
            graph3.AddEdge(new UndirectedEdge(graph3.Vertices[1], graph3.Vertices[2]));
            graph3.AddEdge(new UndirectedEdge(graph3.Vertices[1], graph3.Vertices[3]));
            graph3.AddEdge(new UndirectedEdge(graph3.Vertices[2], graph3.Vertices[4]));
            graph3.AddEdge(new UndirectedEdge(graph3.Vertices[3], graph3.Vertices[4]));
            graph3.AddEdge(new UndirectedEdge(graph3.Vertices[3], graph3.Vertices[5]));
            graph3.AddEdge(new UndirectedEdge(graph3.Vertices[4], graph3.Vertices[5]));
            graph3.AddEdge(new UndirectedEdge(graph3.Vertices[2], graph3.Vertices[6]));
            graph3.AddEdge(new UndirectedEdge(graph3.Vertices[3], graph3.Vertices[6]));
            var graph4 = UndirectedGraph.CreateEmpty(7);
            graph4.AddEdge(new UndirectedEdge(graph4.Vertices[0], graph4.Vertices[1]));
            graph4.AddEdge(new UndirectedEdge(graph4.Vertices[0], graph4.Vertices[2]));
            graph4.AddEdge(new UndirectedEdge(graph4.Vertices[0], graph4.Vertices[5]));
            graph4.AddEdge(new UndirectedEdge(graph4.Vertices[1], graph4.Vertices[2]));
            graph4.AddEdge(new UndirectedEdge(graph4.Vertices[1], graph4.Vertices[3]));
            graph4.AddEdge(new UndirectedEdge(graph4.Vertices[2], graph4.Vertices[3]));
            graph4.AddEdge(new UndirectedEdge(graph4.Vertices[3], graph4.Vertices[4]));
            graph4.AddEdge(new UndirectedEdge(graph4.Vertices[3], graph4.Vertices[5]));
            graph4.AddEdge(new UndirectedEdge(graph4.Vertices[4], graph4.Vertices[5]));
            graph4.AddEdge(new UndirectedEdge(graph4.Vertices[2], graph4.Vertices[6]));
            graph4.AddEdge(new UndirectedEdge(graph4.Vertices[4], graph4.Vertices[6]));
            //var graph5 = UndirectedGraph.CreateEmpty(7);
            #endregion
            #region Группа 6-8
            var graph6 = UndirectedGraph.CreateEmpty(7);
            graph6.AddEdge(new UndirectedEdge(graph6.Vertices[0], graph6.Vertices[1]));
            graph6.AddEdge(new UndirectedEdge(graph6.Vertices[0], graph6.Vertices[2]));
            graph6.AddEdge(new UndirectedEdge(graph6.Vertices[0], graph6.Vertices[5]));
            graph6.AddEdge(new UndirectedEdge(graph6.Vertices[1], graph6.Vertices[2]));
            graph6.AddEdge(new UndirectedEdge(graph6.Vertices[1], graph6.Vertices[4]));
            graph6.AddEdge(new UndirectedEdge(graph6.Vertices[1], graph6.Vertices[6]));
            graph6.AddEdge(new UndirectedEdge(graph6.Vertices[2], graph6.Vertices[3]));
            graph6.AddEdge(new UndirectedEdge(graph6.Vertices[2], graph6.Vertices[4]));
            graph6.AddEdge(new UndirectedEdge(graph6.Vertices[3], graph6.Vertices[5]));
            graph6.AddEdge(new UndirectedEdge(graph6.Vertices[3], graph6.Vertices[6]));
            graph6.AddEdge(new UndirectedEdge(graph6.Vertices[4], graph6.Vertices[6]));
            graph6.AddEdge(new UndirectedEdge(graph6.Vertices[5], graph6.Vertices[6]));
            var graph7 = UndirectedGraph.CreateEmpty(7);
            graph7.AddEdge(new UndirectedEdge(graph7.Vertices[0], graph7.Vertices[1]));
            graph7.AddEdge(new UndirectedEdge(graph7.Vertices[0], graph7.Vertices[2]));
            graph7.AddEdge(new UndirectedEdge(graph7.Vertices[0], graph7.Vertices[5]));
            graph7.AddEdge(new UndirectedEdge(graph7.Vertices[1], graph7.Vertices[2]));
            graph7.AddEdge(new UndirectedEdge(graph7.Vertices[1], graph7.Vertices[4]));
            graph7.AddEdge(new UndirectedEdge(graph7.Vertices[1], graph7.Vertices[6]));
            graph7.AddEdge(new UndirectedEdge(graph7.Vertices[2], graph7.Vertices[3]));
            graph7.AddEdge(new UndirectedEdge(graph7.Vertices[2], graph7.Vertices[4]));
            graph7.AddEdge(new UndirectedEdge(graph7.Vertices[3], graph7.Vertices[5]));
            graph7.AddEdge(new UndirectedEdge(graph7.Vertices[3], graph7.Vertices[0]));
            graph7.AddEdge(new UndirectedEdge(graph7.Vertices[4], graph7.Vertices[6]));
            graph7.AddEdge(new UndirectedEdge(graph7.Vertices[5], graph7.Vertices[6]));
            var graph8 = UndirectedGraph.CreateEmpty(7);
            graph8.AddEdge(new UndirectedEdge(graph8.Vertices[0], graph8.Vertices[1]));
            graph8.AddEdge(new UndirectedEdge(graph8.Vertices[0], graph8.Vertices[5]));
            graph8.AddEdge(new UndirectedEdge(graph8.Vertices[1], graph8.Vertices[2]));
            graph8.AddEdge(new UndirectedEdge(graph8.Vertices[1], graph8.Vertices[4]));
            graph8.AddEdge(new UndirectedEdge(graph8.Vertices[1], graph8.Vertices[6]));
            graph8.AddEdge(new UndirectedEdge(graph8.Vertices[2], graph8.Vertices[3]));
            graph8.AddEdge(new UndirectedEdge(graph8.Vertices[2], graph8.Vertices[4]));
            graph8.AddEdge(new UndirectedEdge(graph8.Vertices[2], graph8.Vertices[5]));
            graph8.AddEdge(new UndirectedEdge(graph8.Vertices[3], graph8.Vertices[0]));
            graph8.AddEdge(new UndirectedEdge(graph8.Vertices[3], graph8.Vertices[5]));
            graph8.AddEdge(new UndirectedEdge(graph8.Vertices[4], graph8.Vertices[6]));
            graph8.AddEdge(new UndirectedEdge(graph8.Vertices[5], graph8.Vertices[6]));
            #endregion
            #region Группа 9-12
            var graph9 = UndirectedGraph.CreateEmpty(8);
            graph9.AddEdge(new UndirectedEdge(graph9.Vertices[0], graph9.Vertices[1]));
            graph9.AddEdge(new UndirectedEdge(graph9.Vertices[1], graph9.Vertices[2]));
            graph9.AddEdge(new UndirectedEdge(graph9.Vertices[2], graph9.Vertices[3]));
            graph9.AddEdge(new UndirectedEdge(graph9.Vertices[3], graph9.Vertices[0]));
            graph9.AddEdge(new UndirectedEdge(graph9.Vertices[4], graph9.Vertices[5]));
            graph9.AddEdge(new UndirectedEdge(graph9.Vertices[5], graph9.Vertices[6]));
            graph9.AddEdge(new UndirectedEdge(graph9.Vertices[6], graph9.Vertices[7]));
            graph9.AddEdge(new UndirectedEdge(graph9.Vertices[7], graph9.Vertices[4]));
            graph9.AddEdge(new UndirectedEdge(graph9.Vertices[0], graph9.Vertices[4]));
            graph9.AddEdge(new UndirectedEdge(graph9.Vertices[1], graph9.Vertices[5]));
            graph9.AddEdge(new UndirectedEdge(graph9.Vertices[2], graph9.Vertices[6]));
            graph9.AddEdge(new UndirectedEdge(graph9.Vertices[3], graph9.Vertices[7]));
            graph9.AddEdge(new UndirectedEdge(graph9.Vertices[0], graph9.Vertices[5]));
            graph9.AddEdge(new UndirectedEdge(graph9.Vertices[1], graph9.Vertices[6]));
            var graph10 = UndirectedGraph.CreateEmpty(8);
            graph10.AddEdge(new UndirectedEdge(graph10.Vertices[0], graph10.Vertices[1]));
            graph10.AddEdge(new UndirectedEdge(graph10.Vertices[1], graph10.Vertices[2]));
            graph10.AddEdge(new UndirectedEdge(graph10.Vertices[2], graph10.Vertices[3]));
            graph10.AddEdge(new UndirectedEdge(graph10.Vertices[3], graph10.Vertices[0]));
            graph10.AddEdge(new UndirectedEdge(graph10.Vertices[4], graph10.Vertices[5]));
            graph10.AddEdge(new UndirectedEdge(graph10.Vertices[5], graph10.Vertices[6]));
            graph10.AddEdge(new UndirectedEdge(graph10.Vertices[6], graph10.Vertices[7]));
            graph10.AddEdge(new UndirectedEdge(graph10.Vertices[7], graph10.Vertices[4]));
            graph10.AddEdge(new UndirectedEdge(graph10.Vertices[0], graph10.Vertices[4]));
            graph10.AddEdge(new UndirectedEdge(graph10.Vertices[1], graph10.Vertices[5]));
            graph10.AddEdge(new UndirectedEdge(graph10.Vertices[2], graph10.Vertices[6]));
            graph10.AddEdge(new UndirectedEdge(graph10.Vertices[3], graph10.Vertices[7]));
            graph10.AddEdge(new UndirectedEdge(graph10.Vertices[0], graph10.Vertices[5]));
            graph10.AddEdge(new UndirectedEdge(graph10.Vertices[3], graph10.Vertices[6]));
            var graph11 = UndirectedGraph.CreateEmpty(8);
            graph11.AddEdge(new UndirectedEdge(graph11.Vertices[0], graph11.Vertices[1]));
            graph11.AddEdge(new UndirectedEdge(graph11.Vertices[1], graph11.Vertices[2]));
            graph11.AddEdge(new UndirectedEdge(graph11.Vertices[2], graph11.Vertices[3]));
            graph11.AddEdge(new UndirectedEdge(graph11.Vertices[3], graph11.Vertices[0]));
            graph11.AddEdge(new UndirectedEdge(graph11.Vertices[4], graph11.Vertices[5]));
            graph11.AddEdge(new UndirectedEdge(graph11.Vertices[5], graph11.Vertices[6]));
            graph11.AddEdge(new UndirectedEdge(graph11.Vertices[6], graph11.Vertices[7]));
            graph11.AddEdge(new UndirectedEdge(graph11.Vertices[7], graph11.Vertices[4]));
            graph11.AddEdge(new UndirectedEdge(graph11.Vertices[0], graph11.Vertices[4]));
            graph11.AddEdge(new UndirectedEdge(graph11.Vertices[1], graph11.Vertices[5]));
            graph11.AddEdge(new UndirectedEdge(graph11.Vertices[2], graph11.Vertices[6]));
            graph11.AddEdge(new UndirectedEdge(graph11.Vertices[3], graph11.Vertices[7]));
            graph11.AddEdge(new UndirectedEdge(graph11.Vertices[1], graph11.Vertices[4]));
            graph11.AddEdge(new UndirectedEdge(graph11.Vertices[2], graph11.Vertices[5]));
            var graph12 = UndirectedGraph.CreateEmpty(8);
            graph12.AddEdge(new UndirectedEdge(graph12.Vertices[0], graph12.Vertices[1]));
            graph12.AddEdge(new UndirectedEdge(graph12.Vertices[1], graph12.Vertices[2]));
            graph12.AddEdge(new UndirectedEdge(graph12.Vertices[2], graph12.Vertices[3]));
            graph12.AddEdge(new UndirectedEdge(graph12.Vertices[3], graph12.Vertices[0]));
            graph12.AddEdge(new UndirectedEdge(graph12.Vertices[4], graph12.Vertices[5]));
            graph12.AddEdge(new UndirectedEdge(graph12.Vertices[5], graph12.Vertices[6]));
            graph12.AddEdge(new UndirectedEdge(graph12.Vertices[6], graph12.Vertices[7]));
            graph12.AddEdge(new UndirectedEdge(graph12.Vertices[7], graph12.Vertices[4]));
            graph12.AddEdge(new UndirectedEdge(graph12.Vertices[0], graph12.Vertices[4]));
            graph12.AddEdge(new UndirectedEdge(graph12.Vertices[1], graph12.Vertices[5]));
            graph12.AddEdge(new UndirectedEdge(graph12.Vertices[2], graph12.Vertices[6]));
            graph12.AddEdge(new UndirectedEdge(graph12.Vertices[3], graph12.Vertices[7]));
            graph12.AddEdge(new UndirectedEdge(graph12.Vertices[1], graph12.Vertices[4]));
            graph12.AddEdge(new UndirectedEdge(graph12.Vertices[3], graph12.Vertices[6]));
            #endregion
            #endregion

            var data = VariantSerializer.Serialize(new IGraph[]
            {
                graph1,
            });
            var taskVariantDto = new TaskVariantDto()
            {
                Data = data,
                GeneratorVersion = "1.0",
                Id = 0,
                TaskId = 1,
                Number = "Вариант 1",
                Version = null
            };

            var client = new VariantGenServiceClient();
            client.SaveVariant(taskVariantDto, 1, false);
        }
    }
}
