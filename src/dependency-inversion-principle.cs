namespace Solid
{
    // Esse princípio diz para você não escrever nenhum código fortemente acoplado, porque esse é um pesadelo a ser mantido 
    // quando o aplicativo está ficando cada vez maior. Se uma classe depende de outra, precisamos alterar uma classe se algo 
    // mudar nessa classe dependente. Devemos sempre tentar escrever uma classe fracamente acoplada.
    public class Email
    {
        public void SendEmail()
        {
            // code to send mail
        }
    }
    public class Notification
    {
        private Email _email;
        public Notification()
        {
            _email = new Email();
        }
        public void PromotionalNotification()
        {
            _email.SendEmail();
        }
    }

    // Agora, a classe Notification depende totalmente da classe Email, porque envia apenas um 
    // tipo de notificação. Se queremos introduzir algum outro SMS, então? Também precisamos alterar o 
    // sistema de notificação. E isso é chamado fortemente acoplado.

    public interface IMessenger
    {
        void SendMessage();
    }
    public class Email : IMessenger
    {
        public void SendMessage()
        {
            // code to send email
        }
    }

    public class SMS : IMessenger
    {
        public void SendMessage()
        {
            // code to send SMS
        }
    }
    public class Notification
    {
        private IMessenger _iMessenger;
        public Notification()
        {
            _ iMessenger = new Email();
        }
        public void DoNotify()
        {
            _ iMessenger.SendMessage();
        }
    }

    // A classe de notificação ainda depende da classe de email. 
    // Agora, podemos usar a injeção de dependência para que possamos acoplá-la livremente. 
    // Existem 3 tipos de DI, injeção de construtor, injeção de propriedade e injeção de método.

    // Constructor Injection
    public class Notification
    {
        private IMessenger _iMessenger;
        public Notification(IMessenger pMessager)
        {
            _iMessenger = pMessager;
        }
        public void DoNotify()
        {
            _iMessenger.SendMessage();
        }
    }

    //Property Injection
    public class Notification
    {
        private IMessenger _iMessenger;

        public Notification() { }

        public IMessenger MessageService
        {
            private get;
            set { _iMessenger = value; }
        }

        public void DoNotify()
        {
            _iMessenger.SendMessage();
        }
    }

    //Method Injection
    public class Notification
    {
        public void DoNotify(IMessenger pMessager)
        {
            pMessager.SendMessage();
        }
    }
}