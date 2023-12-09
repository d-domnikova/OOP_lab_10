using _03BarracksFactory.Contracts;
namespace Problem_3_5.Core
{
    public abstract class Command : IExecutable
    {
        private string[] data;
        private IRepository repository;
        private IUnitFactory unitFactory;

        protected Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            this.data = data;
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        protected string[] Data
        { get { return this.data; } 
          private set { this.data = value; }
        }

        protected IRepository Repository 
        { 
            get { return this.repository; }
            private set {  this.repository = value; }
        }

        protected IUnitFactory UnitFactory
        {
            get { return this.unitFactory; }
            private set { this.unitFactory = value; }
        }

        public abstract string Execute();
    }
}
