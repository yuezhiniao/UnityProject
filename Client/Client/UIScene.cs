using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Client
{
    public enum ESceneType
    {
        Main = 0,
        Nomal = 1,
        Popup =2,  //弹出
        Announce = 3, //公告
    }
    public class UIScene : MonoBehaviour
    {
        protected string mUIName = "";
        private  Dictionary<string, UISceneWidget> mUIWidgets = new Dictionary<string, UISceneWidget>()
            ;
    }
}
