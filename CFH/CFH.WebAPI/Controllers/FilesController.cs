    using Microsoft.AspNet.Identity;
    using System.Web;
    public class FilesController : BaseController
            :base(new CFHData())
            return this.Data.Files
            var fileIds = this.Data.Files.All();
            var files = this.Data.Files
            FileModel file = Data.Files
            this.Data.Files
                this.Data.SaveChanges();
        [Authorize]
        public IHttpActionResult PostFile(FileModel file)
            int userId = int.Parse(User.Identity.GetUserId());
            var user = Data.Users.Find(userId);

            string subPath = "ImagesPath"; // your code goes here

            bool exists = System.IO.Directory.Exists(HttpContext.Current.Server.MapPath("Images"));

            //if (!exists)
            //    System.IO.Directory.CreateDirectory(Server.MapPath(subPath));

            this.Data.Files
            this.Data.SaveChanges();
            File file = this.Data.Files
            this.Data.Files.Delete(file);
            this.Data.SaveChanges();
                this.Data.Dispose();
            return this.Data.Files