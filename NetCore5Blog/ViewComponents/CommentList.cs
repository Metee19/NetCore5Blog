using Microsoft.AspNetCore.Mvc;
using NetCore5Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore5Blog.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,
                    UserName = "Metehan"
                },
                new UserComment
                {
                    Id=2,
                    UserName="Murat"
                }
            };
            return View(commentValues);
        }
    }
}
