﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class NetworkManagerV2Wrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(NetworkManagerV2), typeof(Manager));
		L.RegFunction("OnInit", OnInit);
		L.RegFunction("Update", Update);
		L.RegFunction("Unload", Unload);
		L.RegFunction("SendConnect", SendConnect);
		L.RegFunction("SendMessage", SendMessage);
		L.RegFunction("AddEvent", AddEvent);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("ip", get_ip, set_ip);
		L.RegVar("port", get_port, set_port);
		L.RegVar("newWork", get_newWork, set_newWork);
		L.RegVar("headTimer", get_headTimer, set_headTimer);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnInit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetworkManagerV2 obj = (NetworkManagerV2)ToLua.CheckObject(L, 1, typeof(NetworkManagerV2));
			obj.OnInit();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Update(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetworkManagerV2 obj = (NetworkManagerV2)ToLua.CheckObject(L, 1, typeof(NetworkManagerV2));
			obj.Update();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Unload(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetworkManagerV2 obj = (NetworkManagerV2)ToLua.CheckObject(L, 1, typeof(NetworkManagerV2));
			obj.Unload();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendConnect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			NetworkManagerV2 obj = (NetworkManagerV2)ToLua.CheckObject(L, 1, typeof(NetworkManagerV2));
			obj.SendConnect();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendMessage(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(NetworkManagerV2), typeof(string)))
			{
				NetworkManagerV2 obj = (NetworkManagerV2)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				obj.SendMessage(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(NetworkManagerV2), typeof(LuaFramework.ByteBuffer)))
			{
				NetworkManagerV2 obj = (NetworkManagerV2)ToLua.ToObject(L, 1);
				LuaFramework.ByteBuffer arg0 = (LuaFramework.ByteBuffer)ToLua.ToObject(L, 2);
				obj.SendMessage(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(NetworkManagerV2), typeof(string), typeof(UnityEngine.SendMessageOptions)))
			{
				NetworkManagerV2 obj = (NetworkManagerV2)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				UnityEngine.SendMessageOptions arg1 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 3);
				obj.SendMessage(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(NetworkManagerV2), typeof(string), typeof(object)))
			{
				NetworkManagerV2 obj = (NetworkManagerV2)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				obj.SendMessage(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(NetworkManagerV2), typeof(string), typeof(object), typeof(UnityEngine.SendMessageOptions)))
			{
				NetworkManagerV2 obj = (NetworkManagerV2)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				UnityEngine.SendMessageOptions arg2 = (UnityEngine.SendMessageOptions)ToLua.ToObject(L, 4);
				obj.SendMessage(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: NetworkManagerV2.SendMessage");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
			LuaFramework.ByteBuffer arg1 = (LuaFramework.ByteBuffer)ToLua.CheckObject(L, 2, typeof(LuaFramework.ByteBuffer));
			NetworkManagerV2.AddEvent(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ip(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NetworkManagerV2 obj = (NetworkManagerV2)o;
			string ret = obj.ip;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index ip on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_port(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NetworkManagerV2 obj = (NetworkManagerV2)o;
			int ret = obj.port;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index port on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_newWork(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NetworkManagerV2 obj = (NetworkManagerV2)o;
			SelfNetwork ret = obj.newWork;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index newWork on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_headTimer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NetworkManagerV2 obj = (NetworkManagerV2)o;
			float ret = obj.headTimer;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index headTimer on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ip(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NetworkManagerV2 obj = (NetworkManagerV2)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.ip = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index ip on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_port(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NetworkManagerV2 obj = (NetworkManagerV2)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.port = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index port on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_newWork(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NetworkManagerV2 obj = (NetworkManagerV2)o;
			SelfNetwork arg0 = (SelfNetwork)ToLua.CheckObject(L, 2, typeof(SelfNetwork));
			obj.newWork = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index newWork on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_headTimer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NetworkManagerV2 obj = (NetworkManagerV2)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.headTimer = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index headTimer on a nil value" : e.Message);
		}
	}
}

