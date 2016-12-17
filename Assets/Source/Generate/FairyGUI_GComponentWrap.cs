﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_GComponentWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.GComponent), typeof(FairyGUI.GObject));
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("InvalidateBatchingState", InvalidateBatchingState);
		L.RegFunction("AddChild", AddChild);
		L.RegFunction("AddChildAt", AddChildAt);
		L.RegFunction("RemoveChild", RemoveChild);
		L.RegFunction("RemoveChildAt", RemoveChildAt);
		L.RegFunction("RemoveChildren", RemoveChildren);
		L.RegFunction("GetChildAt", GetChildAt);
		L.RegFunction("GetChild", GetChild);
		L.RegFunction("GetVisibleChild", GetVisibleChild);
		L.RegFunction("GetChildInGroup", GetChildInGroup);
		L.RegFunction("GetChildren", GetChildren);
		L.RegFunction("GetChildIndex", GetChildIndex);
		L.RegFunction("SetChildIndex", SetChildIndex);
		L.RegFunction("SetChildIndexBefore", SetChildIndexBefore);
		L.RegFunction("SwapChildren", SwapChildren);
		L.RegFunction("SwapChildrenAt", SwapChildrenAt);
		L.RegFunction("IsAncestorOf", IsAncestorOf);
		L.RegFunction("AddController", AddController);
		L.RegFunction("GetControllerAt", GetControllerAt);
		L.RegFunction("GetController", GetController);
		L.RegFunction("RemoveController", RemoveController);
		L.RegFunction("GetTransitionAt", GetTransitionAt);
		L.RegFunction("GetTransition", GetTransition);
		L.RegFunction("IsChildInView", IsChildInView);
		L.RegFunction("GetFirstChildInView", GetFirstChildInView);
		L.RegFunction("SetBoundsChangedFlag", SetBoundsChangedFlag);
		L.RegFunction("EnsureBoundsCorrect", EnsureBoundsCorrect);
		L.RegFunction("ConstructFromResource", ConstructFromResource);
		L.RegFunction("ConstructFromXML", ConstructFromXML);
		L.RegFunction("New", _CreateFairyGUI_GComponent);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("rootContainer", get_rootContainer, null);
		L.RegVar("container", get_container, null);
		L.RegVar("scrollPane", get_scrollPane, null);
		L.RegVar("onDrop", get_onDrop, null);
		L.RegVar("fairyBatching", get_fairyBatching, set_fairyBatching);
		L.RegVar("opaque", get_opaque, set_opaque);
		L.RegVar("margin", get_margin, set_margin);
		L.RegVar("childrenRenderOrder", get_childrenRenderOrder, set_childrenRenderOrder);
		L.RegVar("apexIndex", get_apexIndex, set_apexIndex);
		L.RegVar("numChildren", get_numChildren, null);
		L.RegVar("Controllers", get_Controllers, null);
		L.RegVar("clipSoftness", get_clipSoftness, set_clipSoftness);
		L.RegVar("mask", get_mask, set_mask);
		L.RegVar("viewWidth", get_viewWidth, set_viewWidth);
		L.RegVar("viewHeight", get_viewHeight, set_viewHeight);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFairyGUI_GComponent(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FairyGUI.GComponent obj = new FairyGUI.GComponent();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FairyGUI.GComponent.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			obj.Dispose();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InvalidateBatchingState(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GComponent)))
			{
				FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.ToObject(L, 1);
				obj.InvalidateBatchingState();
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GComponent), typeof(bool)))
			{
				FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.ToObject(L, 1);
				bool arg0 = LuaDLL.lua_toboolean(L, 2);
				obj.InvalidateBatchingState(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.GComponent.InvalidateBatchingState");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddChild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.CheckObject(L, 2, typeof(FairyGUI.GObject));
			FairyGUI.GObject o = obj.AddChild(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddChildAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.CheckObject(L, 2, typeof(FairyGUI.GObject));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			FairyGUI.GObject o = obj.AddChildAt(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveChild(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GComponent), typeof(FairyGUI.GObject)))
			{
				FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.ToObject(L, 1);
				FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.ToObject(L, 2);
				FairyGUI.GObject o = obj.RemoveChild(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GComponent), typeof(FairyGUI.GObject), typeof(bool)))
			{
				FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.ToObject(L, 1);
				FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.ToObject(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				FairyGUI.GObject o = obj.RemoveChild(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.GComponent.RemoveChild");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveChildAt(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GComponent), typeof(int)))
			{
				FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				FairyGUI.GObject o = obj.RemoveChildAt(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GComponent), typeof(int), typeof(bool)))
			{
				FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				FairyGUI.GObject o = obj.RemoveChildAt(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.GComponent.RemoveChildAt");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveChildren(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GComponent)))
			{
				FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.ToObject(L, 1);
				obj.RemoveChildren();
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes(L, 1, typeof(FairyGUI.GComponent), typeof(int), typeof(int), typeof(bool)))
			{
				FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				bool arg2 = LuaDLL.lua_toboolean(L, 4);
				obj.RemoveChildren(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.GComponent.RemoveChildren");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChildAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			FairyGUI.GObject o = obj.GetChildAt(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			string arg0 = ToLua.CheckString(L, 2);
			FairyGUI.GObject o = obj.GetChild(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVisibleChild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			string arg0 = ToLua.CheckString(L, 2);
			FairyGUI.GObject o = obj.GetVisibleChild(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChildInGroup(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			FairyGUI.GGroup arg0 = (FairyGUI.GGroup)ToLua.CheckObject(L, 2, typeof(FairyGUI.GGroup));
			string arg1 = ToLua.CheckString(L, 3);
			FairyGUI.GObject o = obj.GetChildInGroup(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChildren(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			FairyGUI.GObject[] o = obj.GetChildren();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChildIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.CheckObject(L, 2, typeof(FairyGUI.GObject));
			int o = obj.GetChildIndex(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetChildIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.CheckObject(L, 2, typeof(FairyGUI.GObject));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj.SetChildIndex(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetChildIndexBefore(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.CheckObject(L, 2, typeof(FairyGUI.GObject));
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			int o = obj.SetChildIndexBefore(arg0, arg1);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SwapChildren(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.CheckObject(L, 2, typeof(FairyGUI.GObject));
			FairyGUI.GObject arg1 = (FairyGUI.GObject)ToLua.CheckObject(L, 3, typeof(FairyGUI.GObject));
			obj.SwapChildren(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SwapChildrenAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj.SwapChildrenAt(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsAncestorOf(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.CheckObject(L, 2, typeof(FairyGUI.GObject));
			bool o = obj.IsAncestorOf(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddController(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			FairyGUI.Controller arg0 = (FairyGUI.Controller)ToLua.CheckObject(L, 2, typeof(FairyGUI.Controller));
			obj.AddController(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetControllerAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			FairyGUI.Controller o = obj.GetControllerAt(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetController(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			string arg0 = ToLua.CheckString(L, 2);
			FairyGUI.Controller o = obj.GetController(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveController(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			FairyGUI.Controller arg0 = (FairyGUI.Controller)ToLua.CheckObject(L, 2, typeof(FairyGUI.Controller));
			obj.RemoveController(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTransitionAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			FairyGUI.Transition o = obj.GetTransitionAt(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTransition(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			string arg0 = ToLua.CheckString(L, 2);
			FairyGUI.Transition o = obj.GetTransition(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsChildInView(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			FairyGUI.GObject arg0 = (FairyGUI.GObject)ToLua.CheckObject(L, 2, typeof(FairyGUI.GObject));
			bool o = obj.IsChildInView(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFirstChildInView(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			int o = obj.GetFirstChildInView();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetBoundsChangedFlag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			obj.SetBoundsChangedFlag();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EnsureBoundsCorrect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			obj.EnsureBoundsCorrect();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ConstructFromResource(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			obj.ConstructFromResource();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ConstructFromXML(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)ToLua.CheckObject(L, 1, typeof(FairyGUI.GComponent));
			FairyGUI.Utils.XML arg0 = (FairyGUI.Utils.XML)ToLua.CheckObject(L, 2, typeof(FairyGUI.Utils.XML));
			obj.ConstructFromXML(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rootContainer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			FairyGUI.Container ret = obj.rootContainer;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index rootContainer on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_container(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			FairyGUI.Container ret = obj.container;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index container on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_scrollPane(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			FairyGUI.ScrollPane ret = obj.scrollPane;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index scrollPane on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDrop(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			FairyGUI.EventListener ret = obj.onDrop;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onDrop on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fairyBatching(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			bool ret = obj.fairyBatching;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index fairyBatching on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_opaque(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			bool ret = obj.opaque;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index opaque on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_margin(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			FairyGUI.Margin ret = obj.margin;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index margin on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_childrenRenderOrder(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			FairyGUI.ChildrenRenderOrder ret = obj.childrenRenderOrder;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index childrenRenderOrder on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_apexIndex(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			int ret = obj.apexIndex;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index apexIndex on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_numChildren(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			int ret = obj.numChildren;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index numChildren on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Controllers(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			System.Collections.Generic.List<FairyGUI.Controller> ret = obj.Controllers;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Controllers on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clipSoftness(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			UnityEngine.Vector2 ret = obj.clipSoftness;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index clipSoftness on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			FairyGUI.DisplayObject ret = obj.mask;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mask on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_viewWidth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			float ret = obj.viewWidth;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index viewWidth on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_viewHeight(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			float ret = obj.viewHeight;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index viewHeight on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fairyBatching(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.fairyBatching = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index fairyBatching on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_opaque(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.opaque = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index opaque on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_margin(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			FairyGUI.Margin arg0 = (FairyGUI.Margin)ToLua.CheckObject(L, 2, typeof(FairyGUI.Margin));
			obj.margin = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index margin on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_childrenRenderOrder(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			FairyGUI.ChildrenRenderOrder arg0 = (FairyGUI.ChildrenRenderOrder)ToLua.CheckObject(L, 2, typeof(FairyGUI.ChildrenRenderOrder));
			obj.childrenRenderOrder = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index childrenRenderOrder on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_apexIndex(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.apexIndex = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index apexIndex on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_clipSoftness(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.clipSoftness = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index clipSoftness on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			FairyGUI.DisplayObject arg0 = (FairyGUI.DisplayObject)ToLua.CheckObject(L, 2, typeof(FairyGUI.DisplayObject));
			obj.mask = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index mask on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_viewWidth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.viewWidth = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index viewWidth on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_viewHeight(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.GComponent obj = (FairyGUI.GComponent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.viewHeight = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index viewHeight on a nil value" : e.Message);
		}
	}
}

