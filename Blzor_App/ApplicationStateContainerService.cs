namespace Blzor_App
{
    public class ApplicationStateContainerService
    {
        /// <summary>
        /// The DataObject
        /// </summary>
        public int StateValue { get; set; } = 0;
        /// <summary>
        /// Event used for Notification
        /// </summary>
        public event Action OnStateChanged;

        /// <summary>
        /// Method to update the state
        /// This will be used by the Sender Component to 
        /// pass the modified value
        /// </summary>
        /// <param name="val"></param>
        public void SetStateValue(int val)
        {
            StateValue = val;
            NotifyStateValueChanged();
        }
        /// <summary>
        /// A provate method that will raise a notification that the StateValue
        /// is changed
        /// </summary>
        private void NotifyStateValueChanged()=> OnStateChanged?.Invoke();
    }
}
