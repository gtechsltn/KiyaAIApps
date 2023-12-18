namespace Blazo_Wasm_Standalone
{
    public class GlobalAppState
    {
        // State Property with initial value
        public int State { get; set; } = 0;
        // An Event that will be fired when the state is changed
        public event Action StateChanged;
        // A Method invoked by the Sender to pass the latest State to GLobal Object
        public void SetState(int s)
        { 
            State = s;
            OnStateChanged();
        }
        // Event Method to Fire an evant
        public void OnStateChanged ()=> StateChanged?.Invoke();

    }
}
