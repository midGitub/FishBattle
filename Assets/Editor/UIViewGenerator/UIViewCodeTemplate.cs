﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeGeneration
{
	using System;
    
    
	public partial class UIViewCodeTemplate : UIViewCodeTemplateBase
	{
        
		public virtual string TransformText ()
		{
			this.GenerationEnvironment = null;
            
			#line 2 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
			this.Write (@"//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System.Collections;

/// <summary>
/// Generates a safe wrapper for ");
            
			#line default
			#line hidden
            
			#line 11 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
			this.Write (this.ToStringHelper.ToStringWithCulture (className));
            
			#line default
			#line hidden
            
			#line 11 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
			this.Write (".\r\n/// </summary>\r\npublic partial class ");
            
			#line default
			#line hidden
            
			#line 13 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
			this.Write (this.ToStringHelper.ToStringWithCulture (className));
            
			#line default
			#line hidden
            
			#line 13 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
			this.Write (" : BaseView\r\n{\r\n");
            
			#line default
			#line hidden
            this.Write ("\tpublic const string NAME =\"{0}\";\r\n", className);
            
			#line 15 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
			foreach (var item in source) {

            
				#line default
				#line hidden
            
				#line 18 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
				this.Write ("\tpublic ");
            
				#line default
				#line hidden
            
				#line 18 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
				this.Write (this.ToStringHelper.ToStringWithCulture (item.comType));
            
				#line default
				#line hidden
            
				#line 18 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
				this.Write (" ");
            
				#line default
				#line hidden
            
				#line 18 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
				this.Write (this.ToStringHelper.ToStringWithCulture (item.memberName));
            
				#line default
				#line hidden
            
				#line 18 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
				this.Write (";\r\n");
            
				#line default
				#line hidden
            
				#line 19 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"

			}

            
			#line default
			#line hidden
            
			#line 22 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
			this.Write ("\r\n\tprotected override void InitElementBinding ()\r\n\t{\r\n");
            
			#line default
			#line hidden
            
            this.Write("\t\tvar root = this.gameObject.transform;\r\n");
            
			#line 25 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
			foreach (var item in source) {

            
				#line default
				#line hidden
            
				#line 28 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
				if (string.IsNullOrEmpty (item.path)) {
            
					#line default
					#line hidden
            
					#line 29 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
					this.Write ("\t");
            
					#line default
					#line hidden
            
					#line 29 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
					this.Write (this.ToStringHelper.ToStringWithCulture (item.memberName));
            
					#line default
					#line hidden
            
					#line 29 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
					this.Write (" = root.GetComponent<");
            
					#line default
					#line hidden
            
					#line 29 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
					this.Write (this.ToStringHelper.ToStringWithCulture (item.comType));
            
					#line default
					#line hidden
            
					#line 29 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
					this.Write (">();\r\n");
            
					#line default
					#line hidden
            
					#line 30 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"

				} else {

					#line default
					#line hidden
            
					#line 33 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
					this.Write ("\t");
            
					#line default
					#line hidden
            
					#line 33 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
					if (item.comType == "Transform") {
            
						#line default
						#line hidden
            
						#line 34 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
						this.Write ("\t");
            
						#line default
						#line hidden
            
						#line 34 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
						this.Write (this.ToStringHelper.ToStringWithCulture (item.memberName));
            
						#line default
						#line hidden
            
						#line 34 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
						this.Write (" = root.Find(\"");
            
						#line default
						#line hidden
            
						#line 34 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
						this.Write (this.ToStringHelper.ToStringWithCulture (item.path));
            
						#line default
						#line hidden
            
						#line 34 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
						this.Write ("\");\r\n");
            
						#line default
						#line hidden
            
						#line 35 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
					} else if (item.comType == "GameObject") {

						this.Write ("\t");

						this.Write (this.ToStringHelper.ToStringWithCulture (item.memberName));

						this.Write (" = root.Find(\"");

						this.Write (this.ToStringHelper.ToStringWithCulture (item.path));

						this.Write ("\").gameObject;\r\n");
					} else {
            
						#line default
						#line hidden
            
						#line 36 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
						this.Write ("\t");
            
						#line default
						#line hidden
            
						#line 36 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
						this.Write (this.ToStringHelper.ToStringWithCulture (item.memberName));
            
						#line default
						#line hidden
            
						#line 36 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
						this.Write (" = root.Find(\"");
            
						#line default
						#line hidden
            
						#line 36 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
						this.Write (this.ToStringHelper.ToStringWithCulture (item.path));
            
						#line default
						#line hidden
            
						#line 36 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
						this.Write ("\").GetComponent<");
            
						#line default
						#line hidden
            
						#line 36 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
						this.Write (this.ToStringHelper.ToStringWithCulture (item.comType));
            
						#line default
						#line hidden
            
						#line 36 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
						this.Write (">();\r\n");
            
						#line default
						#line hidden
            
						#line 37 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"

					}
	
            
					#line default
					#line hidden
            
					#line 40 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"

				}

            
				#line default
				#line hidden
            
				#line 43 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"

			}

            
			#line default
			#line hidden
            
			#line 46 "D:\H1_project\Assets\Editor\UIViewGenerator\UIViewCodeTemplate.tt"
			this.Write ("\t}\r\n}\r\n");
            
			#line default
			#line hidden
			return this.GenerationEnvironment.ToString ();
		}
        
		protected virtual void Initialize ()
		{
		}
	}

	//	########################################	Lua Template Begin	########################################
	public partial class UIViewCodeTemplateToLua : UIViewCodeTemplateBase
	{
		
		public virtual string TransformText ()
		{
			this.GenerationEnvironment = null;
			string tClassName = this.ToStringHelper.ToStringWithCulture (className);
			
			this.Write(string.Format(@"--[==[
	Copyright (C), 2011-2015, Cilu_Nuclear Game Company Tech. Co., Ltd.
	All rights reserved

**	Work:		For H1 Project With ulua
**  FileName:	{0}.lua  ->  Base By uluaBase.lua
**  Version:	Beat R&D
**	Waining:	This code was generated by a tool, Don't Modify It.

**  CreatedBy:	_AuthorName
**  Date:		2015.03.26
**	Modify:		__

**	Url:		http://www.cilugame.com/

**	Description:
**	This program files for detailed instructions to complete the main functions, or functions with other modules interface, the output value of the range, between meaning and parameter control, sequence, independence or dependence relations

*]==]" + "\r\n\n", tClassName));
			//	Generates a safe wrapper for DefaultViewName
			this.Write(string.Format("-- Generates Lua a safe wrapper for {0}\r\n\n", tClassName));

			//	DefaultViewName = {}
			this.Write(string.Format("{0} = UIModuleViewBasic:ctor(\"{1}\")\r\n\n", tClassName, tClassName));
			//this.Write(tClassName + " = {");
			//for (int i = 0, len = source.Count; i < len; i++) {
			//	this.Write(string.Format("\r\n\t{0}", this.ToStringHelper.ToStringWithCulture (source[i].memberName)));
			//	this.Write(string.Format("{0}", (i < len - 1)? "," : "\r\n"));
			//}
			//this.Write("}\r\n");

			//	function DefaultViewName:Setup (viewTransformRoot) ...... end
			this.Write(string.Format("function {0}:Setup (viewTransformRoot)\r\n", tClassName));

			foreach (var item in source) {
				this.Write("\t");

				if (string.IsNullOrEmpty (item.path)) {
					this.Write(string.Format("self.{0} = viewTransformRoot:GetComponent(\'{1}\')\r\n",
					                          this.ToStringHelper.ToStringWithCulture (item.memberName),
					                          this.ToStringHelper.ToStringWithCulture (item.comType)));
				} else {
					if (item.comType == "Transform") {
						this.Write(string.Format("self.{0} = viewTransformRoot:Find(\'{1}\')\r\n",
						                         this.ToStringHelper.ToStringWithCulture (item.memberName),
						                         this.ToStringHelper.ToStringWithCulture (item.path)));
					} else if (item.comType == "GameObject") {
						this.Write(string.Format("self.{0} = viewTransformRoot:Find(\'{1}\').gameObject\r\n",
						                         this.ToStringHelper.ToStringWithCulture (item.memberName),
						                         this.ToStringHelper.ToStringWithCulture (item.path)));
					} else {
						this.Write(string.Format("self.{0} = viewTransformRoot:Find(\'{1}\'):GetComponent(\'{2}\')\r\n",
						                         this.ToStringHelper.ToStringWithCulture (item.memberName),
						                         this.ToStringHelper.ToStringWithCulture (item.path),
						                         this.ToStringHelper.ToStringWithCulture (item.comType)));
					}
				}
			}
			this.Write("end\r\n\n");

			//	function DefaultViewName:Start ...... end
			this.Write(string.Format("function {0}:Start (viewGo)\r\n", tClassName));
			this.Write(string.Format("\twarn(\"In {0}.lua -->> Start Method -> to bind prefab view\")\r\n", tClassName));
			//	self:GetuluaBaseInfo()
			this.Write("\tself:GetuluaBaseInfo()\r\n\n");
			//	self:Setup(viewGo.transform)
			this.Write("\tself:Setup(viewGo.transform)\r\n");
			this.Write("end\r\n\n");

			this.Write(string.Format("return {0}\r\n", tClassName));
			return this.GenerationEnvironment.ToString ();
		}
		
		protected virtual void Initialize ()
		{
		}
	}
	//	########################################	Lua Template End	########################################
	
	public class UIViewCodeTemplateBase
	{
		
		private global::System.Text.StringBuilder builder;
		private global::System.Collections.Generic.IDictionary<string, object> session;
		private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
		private string currentIndent = string.Empty;
		private global::System.Collections.Generic.Stack<int> indents;
		private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper ();
        
		public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
			get {
				return this.session;
			}
			set {
				this.session = value;
			}
		}
        
		public global::System.Text.StringBuilder GenerationEnvironment {
			get {
				if ((this.builder == null)) {
					this.builder = new global::System.Text.StringBuilder ();
				}
				return this.builder;
			}
			set {
				this.builder = value;
			}
		}
        
		protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
			get {
				if ((this.errors == null)) {
					this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection ();
				}
				return this.errors;
			}
		}
        
		public string CurrentIndent {
			get {
				return this.currentIndent;
			}
		}
        
		private global::System.Collections.Generic.Stack<int> Indents {
			get {
				if ((this.indents == null)) {
					this.indents = new global::System.Collections.Generic.Stack<int> ();
				}
				return this.indents;
			}
		}
        
		public ToStringInstanceHelper ToStringHelper {
			get {
				return this._toStringHelper;
			}
		}
        
		public void Error (string message)
		{
			this.Errors.Add (new global::System.CodeDom.Compiler.CompilerError (null, -1, -1, null, message));
		}
        
		public void Warning (string message)
		{
			global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError (null, -1, -1, null, message);
			val.IsWarning = true;
			this.Errors.Add (val);
		}
        
		public string PopIndent ()
		{
			if ((this.Indents.Count == 0)) {
				return string.Empty;
			}
			int lastPos = (this.currentIndent.Length - this.Indents.Pop ());
			string last = this.currentIndent.Substring (lastPos);
			this.currentIndent = this.currentIndent.Substring (0, lastPos);
			return last;
		}
        
		public void PushIndent (string indent)
		{
			this.Indents.Push (indent.Length);
			this.currentIndent = (this.currentIndent + indent);
		}
        
		public void ClearIndent ()
		{
			this.currentIndent = string.Empty;
			this.Indents.Clear ();
		}
        
		public void Write (string textToAppend)
		{
			this.GenerationEnvironment.Append (textToAppend);
		}
        
		public void Write (string format, params object[] args)
		{
			this.GenerationEnvironment.AppendFormat (format, args);
		}
        
		public void WriteLine (string textToAppend)
		{
			this.GenerationEnvironment.Append (this.currentIndent);
			this.GenerationEnvironment.AppendLine (textToAppend);
		}
        
		public void WriteLine (string format, params object[] args)
		{
			this.GenerationEnvironment.Append (this.currentIndent);
			this.GenerationEnvironment.AppendFormat (format, args);
			this.GenerationEnvironment.AppendLine ();
		}
        
		public class ToStringInstanceHelper
		{
            
			private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
			public global::System.IFormatProvider FormatProvider {
				get {
					return this.formatProvider;
				}
				set {
					if ((this.formatProvider == null)) {
						throw new global::System.ArgumentNullException ("formatProvider");
					}
					this.formatProvider = value;
				}
			}
            
			public string ToStringWithCulture (object objectToConvert)
			{
				if ((objectToConvert == null)) {
					throw new global::System.ArgumentNullException ("objectToConvert");
				}
				global::System.Type type = objectToConvert.GetType ();
				global::System.Type iConvertibleType = typeof(global::System.IConvertible);
				if (iConvertibleType.IsAssignableFrom (type)) {
					return ((global::System.IConvertible)(objectToConvert)).ToString (this.formatProvider);
				}
				global::System.Reflection.MethodInfo methInfo = type.GetMethod ("ToString", new global::System.Type[] {
                            iConvertibleType});
				if ((methInfo != null)) {
					return ((string)(methInfo.Invoke (objectToConvert, new object[] {
                                this.formatProvider})));
				}
				return objectToConvert.ToString ();
			}
		}
	}
}
