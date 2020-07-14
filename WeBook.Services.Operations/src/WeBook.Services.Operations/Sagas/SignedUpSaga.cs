using Chronicle;
using MicroS_Common.Services.Identity.Messages.Events;
using System.Threading.Tasks;

namespace WeBook.Services.Operations.Sagas
{
    public class SignedUpSaga : Saga, ISagaStartAction<SignedUp>
    {
        public SignedUpSaga()
        {
        }

        public async Task CompensateAsync(SignedUp message, ISagaContext context)
        {
            await Task.CompletedTask;
        }

        public async Task HandleAsync(SignedUp message, ISagaContext context)
        {
            await CompleteAsync();
            await Task.CompletedTask;
        }
    }
}
