using ILOG.Concert;
using ILOG.CPLEX;

namespace TransportOptimizer
{
    public class Optimizer
    {
        private Problem _problem;
        public Result Result { get; set; } = new Result();

        public Optimizer(string[,] data)
        {
            _problem = new Problem(data);
        }

        public int GetNumberOfSuppliers() => _problem.NumberOfSuppliers;
        public int GetNumberOfConsumers() => _problem.NumberOfConsumers;

        public Result Solve()
        {
            INumVar[][] x = new INumVar[_problem.NumberOfSuppliers][];

            try
            {
                var cplex = new Cplex();
                for (int i = 0; i < _problem.NumberOfSuppliers; i++)                
                    x[i] = cplex.NumVarArray(_problem.NumberOfConsumers, 0.0, int.MaxValue);
                

                for (int i = 0; i < _problem.NumberOfSuppliers; i++)
                    cplex.AddEq(cplex.Sum(x[i]), _problem.Supplies[i]);

                for (int j = 0; j < _problem.NumberOfConsumers; j++)
                {
                    ILinearNumExpr v = cplex.LinearNumExpr();
                    for (int i = 0; i < _problem.NumberOfSuppliers; i++)
                        v.AddTerm(1.0, x[i][j]);
                    cplex.AddEq(v, _problem.Demands[j]);
                }

                ILinearNumExpr expr = cplex.LinearNumExpr();
                for (int i = 0; i < _problem.NumberOfSuppliers; ++i)
                {
                    for (int j = 0; j < _problem.NumberOfConsumers; ++j)
                        expr.AddTerm(x[i][j], _problem.CostMatrix[i][j]);
                }

                cplex.AddMinimize(expr);
                cplex.Solve();

                Result.Solution = new double[_problem.NumberOfSuppliers][];
                for (int i = 0; i < Result.Solution.Length; i++)
                {
                    Result.Solution[i] = new double[_problem.NumberOfConsumers];
                    for (int j = 0; j < _problem.NumberOfConsumers; j++)
                    {
                        Result.Solution[i][j] = cplex.GetValue(x[i][j]);
                    }
                }
                    
                Result.Status = cplex.GetStatus().ToString();
                Result.Cost = int.Parse(cplex.ObjValue.ToString());

                cplex.End();
            }
            catch (Exception icex)
            {
                Result.Error = (icex.Message);
            }            
            return Result;
        }
    }
}
