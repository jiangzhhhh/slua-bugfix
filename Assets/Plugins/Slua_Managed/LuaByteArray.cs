﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_SLua_ByteArray : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			SLua.ByteArray o;
			if(argc==1){
				o=new SLua.ByteArray();
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==2){
				System.Byte[] a1;
				checkArray(l,2,out a1);
				o=new SLua.ByteArray(a1);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetData(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				System.Byte[] a1;
				checkArray(l,2,out a1);
				self.SetData(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				System.Byte[] a1;
				checkArray(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				self.SetData(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function SetData to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Clear(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			self.Clear();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetData(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.GetData();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadBool(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadBool();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadInt(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadInt();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadUInt(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadUInt();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadChar(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadChar();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadUChar(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadUChar();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadByte(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadByte();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Read(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			System.Byte[] a1;
			checkType(l,2,out a1);
			self.Read(ref a1);
			pushValue(l,true);
			pushValue(l,a1);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadSByte(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadSByte();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadShort(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadShort();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadUShort(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadUShort();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadInt16(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadInt16();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadUInt16(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadUInt16();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadInt64(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadInt64();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadFloat(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadFloat();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadDouble(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadDouble();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadString(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadString();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteByteArray(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			SLua.ByteArray a1;
			checkType(l,2,out a1);
			self.WriteByteArray(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteBool(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			System.Boolean a1;
			checkType(l,2,out a1);
			self.WriteBool(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteInt(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.WriteInt(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Write(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(System.UInt16))){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				System.UInt16 a1;
				checkType(l,2,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(System.Int16))){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				System.Int16 a1;
				checkType(l,2,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(System.SByte))){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				System.SByte a1;
				checkType(l,2,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(float))){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				System.Single a1;
				checkType(l,2,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(System.Int64))){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				System.Int64 a1;
				checkType(l,2,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(string))){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				System.String a1;
				checkType(l,2,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(double))){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				System.Double a1;
				checkType(l,2,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(int))){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(bool))){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(SLua.ByteArray))){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				SLua.ByteArray a1;
				checkType(l,2,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(System.UInt32))){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				System.UInt32 a1;
				checkType(l,2,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(System.Byte))){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				System.Byte a1;
				checkType(l,2,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(System.Byte[]))){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				System.Byte[] a1;
				checkArray(l,2,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(System.Char))){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				System.Char a1;
				checkType(l,2,out a1);
				self.Write(a1);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function Write to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteUInt(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				System.UInt32 a1;
				checkType(l,2,out a1);
				self.WriteUInt(a1);
				pushValue(l,true);
				return 1;
			}
			else if(argc==3){
				SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
				System.UInt32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.WriteUInt(a1,a2);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function WriteUInt to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteChar(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			System.SByte a1;
			checkType(l,2,out a1);
			self.WriteChar(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteByte(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			System.Byte a1;
			checkType(l,2,out a1);
			self.WriteByte(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteUChar(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			System.Byte a1;
			checkType(l,2,out a1);
			self.WriteUChar(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteSByte(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			System.SByte a1;
			checkType(l,2,out a1);
			self.WriteSByte(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteUShort(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			System.UInt16 a1;
			checkType(l,2,out a1);
			self.WriteUShort(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteShort(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			System.Int16 a1;
			checkType(l,2,out a1);
			self.WriteShort(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteFloat(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.WriteFloat(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteNum(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			System.Double a1;
			checkType(l,2,out a1);
			self.WriteNum(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteString(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			self.WriteString(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteInt64(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			System.Int64 a1;
			checkType(l,2,out a1);
			self.WriteInt64(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadVarInt(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadVarInt();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteVarInt(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			System.Int64 a1;
			checkType(l,2,out a1);
			self.WriteVarInt(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadInt48(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadInt48();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadInt48L(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadInt48L();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteInt48(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			System.Int64 a1;
			checkType(l,2,out a1);
			self.WriteInt48(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadByteArray(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadByteArray();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadUInt64(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadUInt64();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ReadBytes(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			var ret=self.ReadBytes();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int WriteBytes(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			System.Byte[] a1;
			checkArray(l,2,out a1);
			self.WriteBytes(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Length(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Length);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Position(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.Position);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_Position(IntPtr l) {
		try {
			SLua.ByteArray self=(SLua.ByteArray)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.Position=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"Slua.ByteArray");
		addMember(l,SetData);
		addMember(l,Clear);
		addMember(l,GetData);
		addMember(l,ReadBool);
		addMember(l,ReadInt);
		addMember(l,ReadUInt);
		addMember(l,ReadChar);
		addMember(l,ReadUChar);
		addMember(l,ReadByte);
		addMember(l,Read);
		addMember(l,ReadSByte);
		addMember(l,ReadShort);
		addMember(l,ReadUShort);
		addMember(l,ReadInt16);
		addMember(l,ReadUInt16);
		addMember(l,ReadInt64);
		addMember(l,ReadFloat);
		addMember(l,ReadDouble);
		addMember(l,ReadString);
		addMember(l,WriteByteArray);
		addMember(l,WriteBool);
		addMember(l,WriteInt);
		addMember(l,Write);
		addMember(l,WriteUInt);
		addMember(l,WriteChar);
		addMember(l,WriteByte);
		addMember(l,WriteUChar);
		addMember(l,WriteSByte);
		addMember(l,WriteUShort);
		addMember(l,WriteShort);
		addMember(l,WriteFloat);
		addMember(l,WriteNum);
		addMember(l,WriteString);
		addMember(l,WriteInt64);
		addMember(l,ReadVarInt);
		addMember(l,WriteVarInt);
		addMember(l,ReadInt48);
		addMember(l,ReadInt48L);
		addMember(l,WriteInt48);
		addMember(l,ReadByteArray);
		addMember(l,ReadUInt64);
		addMember(l,ReadBytes);
		addMember(l,WriteBytes);
		addMember(l,"Length",get_Length,null,true);
		addMember(l,"Position",get_Position,set_Position,true);
		createTypeMetatable(l,constructor, typeof(SLua.ByteArray));
	}
}
