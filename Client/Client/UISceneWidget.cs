using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events


    /// <summary>
    /// 界面控制基类
    /// </summary>
    public class UISceneWidget
    {
        public bool IsOnPointerClick;
        public event Action<PointerEventData> BeginDrag;
        public event Action<BaseEventData> Cancel;
        public event Action<BaseEventData> Deselect;
        public event Action<PointerEventData> Drag;
        public event Action<PointerEventData> Drop;
        public event Action<PointerEventData> EndDrag;
        public event Action<PointerEventData> InitializePotentialDrag;
        public event Action<AxisEventData> Move;
        public event Action<PointerEventData> PointerClick;
        public event Action<PointerEventData> PointerDown;
        public event Action<PointerEventData> PointerEnter;
        public event Action<PointerEventData> PointerExit;
        public event Action<PointerEventData> PointerUp;
        public event Action<PointerEventData> Scroll;
        public event Action<BaseEventData> Select;
        public event Action<BaseEventData> Submit;
        public event Action<BaseEventData> UpdateSelected;

        /// <summary>
        /// 获取指定UGUI游戏物体的事件监听器
        /// </summary>
        /// <param name="go"></param>
        /// <returns></returns>
        public static UISceneWidget Get(GameObject go)
        {
            UISceneWidget widget = go.GetComponent<UISceneWidget>();
            if (!widget) widget = go.AddComponent<UISceneWidget>();
            return widget;
    }
    }

