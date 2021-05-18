using GestionProject.Data;
using GestionProject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GestionProject.Controllers
{
	public class ChatController
	{
		private readonly AppDbContext _appDbContext;

		public ChatController(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}
       

        [HttpPost]
        public IActionResult Index(IFormFile files)
        {
            if (files != null)
            {
                if (files.Length > 0)
                {
                    //Getting FileName
                    var fileName = Path.GetFileName(files.FileName);
                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);
                    // concatenating  FileName + FileExtension
                    var newFileName = String.Concat(Convert.ToString(Guid.NewGuid()), fileExtension);

                    var chat = new ChatViewModel()
                    {
                        DocumentId = 0,
                        Name = newFileName,
                        FileType = fileExtension,
                        when = DateTime.Now
                    };

                    using (var target = new MemoryStream())
                    {
                        files.CopyTo(target);
                       chat.DataFiles = target.ToArray();
                    }

                    _appDbContext.Chats.Add(chat);
                    _appDbContext.SaveChanges();

                }
            }
            return View();
        }
    }
}