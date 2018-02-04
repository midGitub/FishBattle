﻿//
// Automatically generated by JSComponentGenerator.
//
using UnityEngine;

public class JSComponent_TransChange_Physics_Render : JSComponent
{
    int idOnTransformChildrenChanged;
    int idOnTransformParentChanged;
    int idOnCollisionEnter;
    int idOnCollisionExit;
    int idOnCollisionStay;
    int idOnTriggerEnter;
    int idOnTriggerExit;
    int idOnTriggerStay;
    int idOnControllerColliderHit;
    int idOnCollisionEnter2D;
    int idOnCollisionExit2D;
    int idOnCollisionStay2D;
    int idOnTriggerEnter2D;
    int idOnTriggerExit2D;
    int idOnTriggerStay2D;
    int idOnPostRender;
    int idOnPreCull;
    int idOnPreRender;
    int idOnRenderObject;
    int idOnWillRenderObject;

    protected override void initMemberFunction()
    {
        base.initMemberFunction();
        idOnTransformChildrenChanged = JSApi.getObjFunction(jsObjID, "OnTransformChildrenChanged");
        idOnTransformParentChanged = JSApi.getObjFunction(jsObjID, "OnTransformParentChanged");
        idOnCollisionEnter = JSApi.getObjFunction(jsObjID, "OnCollisionEnter");
        idOnCollisionExit = JSApi.getObjFunction(jsObjID, "OnCollisionExit");
        idOnCollisionStay = JSApi.getObjFunction(jsObjID, "OnCollisionStay");
        idOnTriggerEnter = JSApi.getObjFunction(jsObjID, "OnTriggerEnter");
        idOnTriggerExit = JSApi.getObjFunction(jsObjID, "OnTriggerExit");
        idOnTriggerStay = JSApi.getObjFunction(jsObjID, "OnTriggerStay");
        idOnControllerColliderHit = JSApi.getObjFunction(jsObjID, "OnControllerColliderHit");
        idOnCollisionEnter2D = JSApi.getObjFunction(jsObjID, "OnCollisionEnter2D");
        idOnCollisionExit2D = JSApi.getObjFunction(jsObjID, "OnCollisionExit2D");
        idOnCollisionStay2D = JSApi.getObjFunction(jsObjID, "OnCollisionStay2D");
        idOnTriggerEnter2D = JSApi.getObjFunction(jsObjID, "OnTriggerEnter2D");
        idOnTriggerExit2D = JSApi.getObjFunction(jsObjID, "OnTriggerExit2D");
        idOnTriggerStay2D = JSApi.getObjFunction(jsObjID, "OnTriggerStay2D");
        idOnPostRender = JSApi.getObjFunction(jsObjID, "OnPostRender");
        idOnPreCull = JSApi.getObjFunction(jsObjID, "OnPreCull");
        idOnPreRender = JSApi.getObjFunction(jsObjID, "OnPreRender");
        idOnRenderObject = JSApi.getObjFunction(jsObjID, "OnRenderObject");
        idOnWillRenderObject = JSApi.getObjFunction(jsObjID, "OnWillRenderObject");
    }

    void OnTransformChildrenChanged()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTransformChildrenChanged);
    }
    void OnTransformParentChanged()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTransformParentChanged);
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnCollisionEnter, collisionInfo);
    }
    void OnCollisionExit(Collision collisionInfo)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnCollisionExit, collisionInfo);
    }
    void OnCollisionStay(Collision collisionInfo)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnCollisionStay, collisionInfo);
    }
    void OnTriggerEnter(Collider other)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTriggerEnter, other);
    }
    void OnTriggerExit(Collider other)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTriggerExit, other);
    }
    void OnTriggerStay(Collider other)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTriggerStay, other);
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnControllerColliderHit, hit);
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnCollisionEnter2D, coll);
    }
    void OnCollisionExit2D(Collision2D coll)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnCollisionExit2D, coll);
    }
    void OnCollisionStay2D(Collision2D coll)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnCollisionStay2D, coll);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTriggerEnter2D, other);
    }
    void OnTriggerExit2D(Collider2D other)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTriggerExit2D, other);
    }
    void OnTriggerStay2D(Collider2D other)
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnTriggerStay2D, other);
    }
    void OnPostRender()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnPostRender);
    }
    void OnPreCull()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnPreCull);
    }
    void OnPreRender()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnPreRender);
    }
    void OnRenderObject()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnRenderObject);
    }
    void OnWillRenderObject()
    {
        JSMgr.vCall.CallJSFunctionValue(jsObjID, idOnWillRenderObject);
    }

}