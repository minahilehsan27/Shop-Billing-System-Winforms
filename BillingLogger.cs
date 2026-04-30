using System;

namespace WindowsFormsApp_hw
{ 
    public class BillingLogger
    {
        private Action<string> logWriter;

        public BillingLogger(Action<string> logWriter)
        {
            this.logWriter = logWriter ?? throw new ArgumentNullException(nameof(logWriter));
        }

        public void OnItemAddedHandler(string itemInfo)
        {
            string logMessage = $"{DateTime.Now:HH:mm:ss} - ITEM ADDED: {itemInfo}";
            logWriter?.Invoke(logMessage);
        }

        public void OnBillCalculatedHandler(string billInfo)
        {
            string logMessage = $"{DateTime.Now:HH:mm:ss} - BILL CALCULATED: {billInfo}";
            logWriter?.Invoke(logMessage);
        }

        public void OnBillClearedHandler(string clearInfo)
        {
            string logMessage = $"{DateTime.Now:HH:mm:ss} - BILL CLEARED: {clearInfo}";
            logWriter?.Invoke(logMessage);
        }
    }
}
