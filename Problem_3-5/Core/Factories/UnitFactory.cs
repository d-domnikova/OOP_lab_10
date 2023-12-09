namespace _03BarracksFactory.Core.Factories
{
    using System;
    using _03BarracksFactory.Models.Units;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            Type type = typeof(Unit);
            var nspace = type.Namespace;

            Type typeOfUnit = Type.GetType($"{nspace}.{unitType}");
            IUnit create = (IUnit)Activator.CreateInstance(typeOfUnit);

            return create;

        }
    }
}
