using GraphLabs.Graphs;
using GraphLabs.Graphs.DataTransferObjects.Converters;
using variantgenerator_script.ServiceReference;

namespace variantgenerator_script
{
    class Program
    {
        static void Main(string[] args)
        {
            var graphA = UndirectedGraph.CreateEmpty(3);
            graphA.AddEdge(new UndirectedEdge(graphA.Vertices[0], graphA.Vertices[1]));
            var data = VariantSerializer.Serialize(new IGraph[]
            {
                graphA,
            });
            var taskVariantDto = new TaskVariantDto()
            {
                Data = data,
                GeneratorVersion = "1.0",
                Id = 0,
                TaskId = 0,
                Number = "Вариант 1",
                Version = null
            };

            var client = new VariantGenServiceClient();
            client.SaveVariant(taskVariantDto, 0, false);
        }
    }
}
