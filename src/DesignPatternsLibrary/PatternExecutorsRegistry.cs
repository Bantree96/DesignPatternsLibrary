﻿using System.Collections.Generic;
using DesignPatternsLibrary.PatternExecutors;

namespace DesignPatternsLibrary
{
    public class PatternExecutorsRegistry
    {
        private static PatternExecutorsRegistry _instance = null;

        private readonly SortedDictionary<int, PatternExecutor> _executors;

        private PatternExecutorsRegistry()
        {
            _executors = new SortedDictionary<int, PatternExecutor>
            {
                { 1, new Greeter.Executor() },
                { 2, new RestaurantManagement.Executor() },
                { 3, new MealSimpleFactory.Executor() },
                { 4, new RestaurantAbstractFactory.Executor() },
                { 5, new CustomSandwichBuilder.Executor() },
                { 6, new PrototypeLibrary.Executor() },
                { 7, new AdapterLibrary.Executor() },
                { 8, new BridgeLibrary.Executor() },
                { 9, new CompositeLibrary.Executor() },
                { 10, new DecoratorLibrary.Executor() },
                { 11, new FacadeLibrary.Executor() },
                { 12, new FlyweightLibrary.Executor() },
                { 13, new ProxyLibrary.Executor() },
                { 14, new ChainOfResponsibilityLibrary.Executor() },
                { 15, new CommandLibrary.Executor() },
                { 16, new IteratorLibrary.Executor() },
                { 17, new MediatorLibrary.Executor() },
                { 18, new MementoLibrary.Executor() },
                { 19, new ObserverLibrary.Executor() },
                { 20, new StateLibrary.Executor() },
                { 21, new StrategyLibrary.Executor() },
                { 22, new TemplateMethodLibrary.Executor() },
                { 23, new VisitorLibrary.Executor() },
                { 24, new EventAggregatorLibrary.Executor() },
                { 25, new InterpreterLibrary.Executor() },
                { 26, new LazyLoadLibrary.Executor() },
                { 27, new NullObjectLibrary.Executor() },
                { 28, new OrderManagement.Executor() },
                { 29, new RulesLibrary.Executor() },
                { 30, new OrderProcessing.Executor() },
                { 31, new UnitOfWorkLibrary.Executor() },
            };
        }

        public static PatternExecutorsRegistry Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PatternExecutorsRegistry();
                }

                return _instance;
            }
        }

        public SortedDictionary<int, PatternExecutor> GetAll()
        {
            return _executors;
        }
    }
}
