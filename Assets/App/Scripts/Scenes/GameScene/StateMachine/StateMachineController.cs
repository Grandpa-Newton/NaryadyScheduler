using System;
using System.Collections.Generic;
using App.Scripts.Modules.StateMachine;
using App.Scripts.Scenes.GameScene.StateMachine.States;
using Zenject;

namespace App.Scripts.Scenes.GameScene.StateMachine
{
    public class StateMachineController : IInitializable, IStateMachineController
    {
        private readonly IState[] _states;
        private readonly IStateMachine _stateMachine;
        private readonly Dictionary<Type, IState> _statesDictionary = new Dictionary<Type, IState>();

        public StateMachineController(IStateMachine stateMachine, List<IState> states)
        {
            _stateMachine = stateMachine;
            _states = states.ToArray();
        }
        public void Initialize()
        {
            foreach (var state in _states)
            {
                _statesDictionary[state.GetType()] = state;
            }
            
            ChangeState<MenuState>(); //TODO: точно ли тут?
        }
        
        public void ChangeState<T>() where T : IState
        {
            if (_statesDictionary.TryGetValue(typeof(T), out var state))
            {
                _stateMachine.ChangeState(state);
            }
        }
    }
}