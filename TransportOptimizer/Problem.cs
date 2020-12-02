using System.Linq;

namespace TransportOptimizer
{
    public class Problem
    {
        private string[,] _rawData { get; set; }
        public int NumberOfSuppliers { get; set; }
        public int NumberOfConsumers { get; set; }
        public int[] Supplies { get; set; }
        public int[] Demands { get; set; }
        public int TotalSupply { get; set; }
        public int TotalDemand { get; set; }
        public int[][] CostMatrix { get; set; }

        public Problem(string[,] data)
        {
            _rawData = data;
            NumberOfSuppliers = data.GetLength(0) - 1;
            NumberOfConsumers = data.GetLength(1) - 1;
            SetSupplies(data);
            SetDemands(data);
            SetCostMatrix(data);
        }        

        private void SetSupplies(string[,]  data)
        {            
            Supplies = new int[NumberOfSuppliers];
            for (int i = 0; i < NumberOfSuppliers; i++)
            {
                int.TryParse(_rawData[i, NumberOfConsumers], out var value);
                Supplies[i] = value;
            }
                
            TotalSupply = Supplies.Sum();
        }

        private void SetDemands(string[,] data)
        {            
            Demands = new int[NumberOfConsumers];
            for (int i = 0; i < NumberOfConsumers; i++)
                Demands[i] = int.Parse(_rawData[NumberOfSuppliers, i]);
            TotalDemand = Demands.Sum();
        }

        private void SetCostMatrix(string[,] data)
        {
            //InitCostMatrix();
            CostMatrix = new int[NumberOfSuppliers][];        // Set number of rows
            for (int row = 0; row < NumberOfSuppliers; row++)
            {
                CostMatrix[row] = new int[NumberOfConsumers]; // Set number of cols
                for (int col = 0; col < NumberOfConsumers; col++)
                    CostMatrix[row][col] = int.Parse(data[row, col].ToString());
            }                                
        }       
    }
}
