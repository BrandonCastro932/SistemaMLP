using System.Threading;
using System.Windows.Forms;

namespace SistemaMLP.Forms.WaitingForm
{
    public class FrmWaitingFunc
    {
        WaitingForm.FrmWaiting waiting;
        Thread loadThread;

        public void Show()
        {
            loadThread = new Thread(new ThreadStart(LoadingProcess));
            loadThread.Start();
        }

        public void Show(Form parent)
        {
            loadThread = new Thread(new ParameterizedThreadStart(LoadingProcess));
            loadThread.Start(parent);
        }

        public void Close()
        {
            if (waiting != null)
            {
                waiting.BeginInvoke(new System.Threading.ThreadStart(waiting.CloseWaitForm));
                waiting = null;
                loadThread = null;
            }
        }

        private void LoadingProcess()
        {
            waiting = new FrmWaiting();
            waiting.ShowDialog();
        }

        private void LoadingProcess(object parent)
        {
            Form parent1 = parent as Form;
            waiting = new FrmWaiting(parent1);
            waiting.ShowDialog();
        }
    }
}
