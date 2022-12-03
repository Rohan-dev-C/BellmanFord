using System.Collections;

namespace BellmanFord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IComparer<int> comparer = Comparer<int>.Default;
            Graph<int> graph = new Graph<int>(comparer);  
            Console.WriteLine("Hello, World!");


            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);
            graph.AddVertex(5);
            graph.AddVertex(6);
            graph.AddEdge(1, 2, 1); 
            graph.AddEdge(2, 3, 1); 
            graph.AddEdge(3, 4, -1); 
            graph.AddEdge(4, 5, -1); 
            graph.AddEdge(3, 5, -1); 
            graph.AddEdge(4, 6, 1);


            var result = Pathfinding<int>.BellmanFord(graph); 
        }
    }
}