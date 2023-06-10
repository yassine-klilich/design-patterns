using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_DP.Chain_of_Responsibility_DP
{
    interface IHandler
    {
        public IHandler SetNextHandler(IHandler handler);
        public void Handle(string request);
    }

    class BaseHandler : IHandler
    {
        private IHandler? _nextHandler;

        public IHandler SetNextHandler(IHandler handler)
        {
            return _nextHandler = handler;
        }

        public virtual void Handle(string request)
        {
            if (_nextHandler != null)
            {
                Console.WriteLine(_nextHandler.GetHashCode());
                _nextHandler.Handle(request);
            }
        }
    }

    class Handler_A : BaseHandler
    {
        public override void Handle(string request)
        {
            if (request == "A")
            {
                Console.WriteLine("Handled in A");
                return;
            }

            base.Handle(request);
        }
    }

    class Handler_B : BaseHandler
    {
        public override void Handle(string request)
        {
            if (request == "B")
            {
                Console.WriteLine("Handled in B");
                return;
            }

            base.Handle(request);
        }
    }

    class Handler_C : BaseHandler
    {
        public override void Handle(string request)
        {
            if (request == "C")
            {
                Console.WriteLine("Handled in C");
                return;
            }

            base.Handle(request);
        }
    }
}
