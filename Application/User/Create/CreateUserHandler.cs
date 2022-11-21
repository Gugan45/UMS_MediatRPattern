using MediatR;


namespace Application.User.Create
{
    public class CreateCommentHandler : IRequestHandler<CreateUser, bool>
    {
        public async Task<bool> Handle(CreateUser request, CancellationToken cancellationToken)
        {
            
            return true;
        }
    }
}   