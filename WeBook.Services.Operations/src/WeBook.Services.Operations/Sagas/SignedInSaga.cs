using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chronicle;
using MicroS_Common.RabbitMq;
using MicroS_Common.Services.Identity.Messages.Events;

namespace WeBook.Services.Operations.Sagas
{
    public class SignedInSaga : Saga, ISagaStartAction<SignedIn>
    {
        private readonly IBusPublisher _busPublisher;
        public SignedInSaga(IBusPublisher busPublisher)
        {
            _busPublisher = busPublisher;
        }
        public override SagaId ResolveId(object message, ISagaContext context)
        {
            switch (message)
            {
                case SignedIn m: return SagaId.NewSagaId();
                default: return base.ResolveId(message, context);
            }
        }
        public async Task CompensateAsync(SignedIn message, ISagaContext context)
        {
            await Task.CompletedTask;
        }

        public async Task HandleAsync(SignedIn message, ISagaContext context)
        {
            Complete();
            await Task.CompletedTask;
        }
    }
}
