﻿using UnityEngine;

namespace RPG.Core
{
    public class ActionScheduler : MonoBehaviour
    {

//---------------Nesneler---------------

        IAction currentAction;

//---------------Metotlar---------------

        public void StartAction(IAction action)
        {
            if (currentAction == action)
            {
                return;
            }
            
            if (currentAction != null)
            {
                currentAction.Cancel();
            }

            currentAction = action;
        }

        public void CancelCurrentAction()
        {
            StartAction(null);
        }
    }
}
