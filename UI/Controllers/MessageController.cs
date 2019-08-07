using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models.Message;
using DevTrends.MvcDonutCaching;
using System.Web.Caching;

namespace UI.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        //[OutputCache(Duration = 100, VaryByParam = "Id")]
        [DonutOutputCache(Duration = 100/*CacheProfile = "FiveMins"*/)]
        public ActionResult Mine()
        {
            //    public object Add(
            //string key, object value, //键值对
            //CacheDependency dependencies, //主要适用于文件，当文件发生变动时，删除当前缓存
            //DateTime absoluteExpiration,
            //TimeSpan slidingExpiration,
            //CacheItemPriority priority, //优先级
            //CacheItemRemovedCallback onRemoveCallback);
            string Cachekay = "Message_Mine";
            string CacheValue = "缓存的值";//GetFromDb();一般用一个方法从数据库取想要缓存的值
            if (HttpContext.Cache[Cachekay]==null)
            {
                HttpContext.Cache.Add(
             Cachekay,
             CacheValue,
             null,
             DateTime.Now.AddSeconds(120),
             new TimeSpan(0, 0, 120),
             CacheItemPriority.Low,
             (key, value, reason) =>
             {

             });
            }
            ViewData[Cachekay] = HttpContext.Cache[Cachekay];

            MineModel model = new MineModel
            {
                Messages = new List<MessageItemModel>
                {
                    new MessageItemModel{Content="消息1",Id=1},
                    new MessageItemModel{Content="消息2",Id=2},
                    new MessageItemModel{Content="消息3",Id=3}

                }
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Mine(MineModel model)
        {
            foreach (var item in model.Messages)
            {
                if (item.Selected)
                {

                }
            }
            return RedirectToAction("Mine");
        }


    }
}