﻿using UnityEngine;
using System.Collections;

namespace LuaFramework
{
    public class GameManagerV2 : Manager
    {

        /// <summary>
        /// 初始化游戏管理器
        /// </summary>
        void Awake()
        {
            Init();
        }


        void Init()
        {
            DontDestroyOnLoad(gameObject);  //防止销毁自己

            OnResourceInited();
        }

        public void OnResourceInited()
        {
            LuaManager.InitStart();
            LuaManager.DoFile("Logic/Game");            //加载游戏
            //LuaManager.DoFile("Logic/Network");         //加载网络
            //NetManager.OnInit();

            Util.CallMethod("Game", "OnInitOK");          //初始化完成
        }
    }
}

