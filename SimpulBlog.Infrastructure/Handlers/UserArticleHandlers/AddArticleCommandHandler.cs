﻿using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SimpulBlog.Infrastructure.Commands.UserArticleCommands;
using SimpulBlog.Infrastructure.Services.Abstract;

namespace SimpulBlog.Infrastructure.Handlers.UserArticleHandlers
{
    public class AddArticleCommandHandler : IRequestHandler<AddArticleCommand>
    {
        private readonly IUserArticleService articleService;

        public AddArticleCommandHandler(IUserArticleService articleService)
        {
            this.articleService = articleService;
        }

        public async Task<Unit> Handle(AddArticleCommand request, CancellationToken cancellationToken)
        {
            await articleService.AddArticle(request);
            return Unit.Value;;
        }
    }
}
