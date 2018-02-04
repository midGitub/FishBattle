// Shader created with Shader Forge v1.28 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.28;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:1,fgcg:0.4527383,fgcb:0.4411765,fgca:1,fgde:0.01,fgrn:-43.8,fgrf:384.7,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True;n:type:ShaderForge.SFN_Final,id:4795,x:32545,y:32925,varname:node_4795,prsc:2|emission-2393-OUT,alpha-798-OUT;n:type:ShaderForge.SFN_Tex2d,id:6074,x:31755,y:33155,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:_MainTex,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:0,isnm:False|UVIN-1540-OUT;n:type:ShaderForge.SFN_Multiply,id:2393,x:32237,y:32994,varname:node_2393,prsc:2|A-4903-OUT,B-2053-RGB,C-797-RGB,D-6074-RGB;n:type:ShaderForge.SFN_VertexColor,id:2053,x:31766,y:32825,varname:node_2053,prsc:2;n:type:ShaderForge.SFN_Color,id:797,x:31766,y:32983,ptovrint:True,ptlb:Color,ptin:_TintColor,varname:_TintColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:798,x:32254,y:33216,varname:node_798,prsc:2|A-2053-A,B-797-A,C-6074-A,D-461-OUT;n:type:ShaderForge.SFN_Tex2d,id:9704,x:30417,y:33085,ptovrint:False,ptlb:Noise 01,ptin:_Noise01,varname:node_9704,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:9a3c093aa80a8c34ca15053ab7abda2c,ntxv:0,isnm:False|UVIN-2778-OUT;n:type:ShaderForge.SFN_Append,id:2778,x:30227,y:33054,varname:node_2778,prsc:2|A-8813-OUT,B-6750-OUT;n:type:ShaderForge.SFN_TexCoord,id:8230,x:29851,y:33093,varname:node_8230,prsc:2,uv:0;n:type:ShaderForge.SFN_Add,id:8813,x:30047,y:32979,varname:node_8813,prsc:2|A-2506-OUT,B-8230-U;n:type:ShaderForge.SFN_Multiply,id:2506,x:29815,y:32919,varname:node_2506,prsc:2|A-9982-T,B-5869-OUT;n:type:ShaderForge.SFN_Time,id:9982,x:29582,y:32859,varname:node_9982,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:5869,x:29613,y:33082,ptovrint:False,ptlb:U_Speed,ptin:_U_Speed,varname:node_5869,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-0.3;n:type:ShaderForge.SFN_Add,id:6750,x:30019,y:33256,varname:node_6750,prsc:2|A-8230-V,B-9086-OUT;n:type:ShaderForge.SFN_Multiply,id:9086,x:29768,y:33255,varname:node_9086,prsc:2|A-9955-T,B-3622-OUT;n:type:ShaderForge.SFN_Time,id:9955,x:29558,y:33195,varname:node_9955,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:3622,x:29595,y:33422,ptovrint:False,ptlb:V_Speed,ptin:_V_Speed,varname:_node_5869_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-0.2;n:type:ShaderForge.SFN_Multiply,id:3853,x:31151,y:33192,varname:node_3853,prsc:2|A-8424-OUT,B-3517-OUT;n:type:ShaderForge.SFN_Add,id:1540,x:31378,y:33166,varname:node_1540,prsc:2|A-6037-UVOUT,B-3853-OUT;n:type:ShaderForge.SFN_ValueProperty,id:4903,x:31749,y:32750,ptovrint:False,ptlb:ZT,ptin:_ZT,varname:node_4903,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:1;n:type:ShaderForge.SFN_Tex2d,id:5494,x:30414,y:33517,ptovrint:False,ptlb:Noise 02,ptin:_Noise02,varname:_node_9704_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7acc33f24a06fcd46baa112415b42195,ntxv:0,isnm:False|UVIN-9617-OUT;n:type:ShaderForge.SFN_Append,id:9617,x:30203,y:33537,varname:node_9617,prsc:2|A-3085-OUT,B-1401-OUT;n:type:ShaderForge.SFN_TexCoord,id:4987,x:29827,y:33576,varname:node_4987,prsc:2,uv:0;n:type:ShaderForge.SFN_Add,id:3085,x:30023,y:33462,varname:node_3085,prsc:2|A-9194-OUT,B-4987-U;n:type:ShaderForge.SFN_Multiply,id:9194,x:29791,y:33402,varname:node_9194,prsc:2|A-1896-T,B-5069-OUT;n:type:ShaderForge.SFN_Time,id:1896,x:29459,y:33296,varname:node_1896,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:5069,x:29589,y:33565,ptovrint:False,ptlb:U_Speed_copy,ptin:_U_Speed_copy,varname:_U_Speed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:-0.3;n:type:ShaderForge.SFN_Add,id:1401,x:29995,y:33739,varname:node_1401,prsc:2|A-4987-V,B-8884-OUT;n:type:ShaderForge.SFN_Multiply,id:8884,x:29744,y:33738,varname:node_8884,prsc:2|A-8589-T,B-4099-OUT;n:type:ShaderForge.SFN_Time,id:8589,x:29534,y:33678,varname:node_8589,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:4099,x:29542,y:33901,ptovrint:False,ptlb:V_Speed_copy,ptin:_V_Speed_copy,varname:_V_Speed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.2;n:type:ShaderForge.SFN_Multiply,id:1243,x:30678,y:33218,varname:node_1243,prsc:2|A-9704-RGB,B-5494-RGB;n:type:ShaderForge.SFN_ComponentMask,id:8424,x:30912,y:33213,varname:node_8424,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-1243-OUT;n:type:ShaderForge.SFN_TexCoord,id:6037,x:31116,y:32990,varname:node_6037,prsc:2,uv:0;n:type:ShaderForge.SFN_Slider,id:3517,x:30787,y:33426,ptovrint:False,ptlb:Disturbance,ptin:_Disturbance,varname:node_3517,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4607778,max:10;n:type:ShaderForge.SFN_Slider,id:461,x:31736,y:33435,ptovrint:False,ptlb:Alpha,ptin:_Alpha,varname:node_461,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.060438,max:2;proporder:6074-797-4903-461-3517-9704-5869-3622-5494-5069-4099;pass:END;sub:END;*/

Shader "H2/H_Disturbance_Blend" {
    Properties {
        _MainTex ("MainTex", 2D) = "white" {}
        _TintColor ("Color", Color) = (1,1,1,1)
        _ZT ("ZT", Float ) = 1
        _Alpha ("Alpha", Range(0, 2)) = 1.060438
        _Disturbance ("Disturbance", Range(0, 10)) = 0.4607778
        _Noise01 ("Noise 01", 2D) = "white" {}
        _U_Speed ("U_Speed", Float ) = -0.3
        _V_Speed ("V_Speed", Float ) = -0.2
        _Noise02 ("Noise 02", 2D) = "white" {}
        _U_Speed_copy ("U_Speed_copy", Float ) = -0.3
        _V_Speed_copy ("V_Speed_copy", Float ) = 0.2
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
           // #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            //#pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _TintColor;
            uniform sampler2D _Noise01; uniform float4 _Noise01_ST;
            uniform float _U_Speed;
            uniform float _V_Speed;
            uniform float _ZT;
            uniform sampler2D _Noise02; uniform float4 _Noise02_ST;
            uniform float _U_Speed_copy;
            uniform float _V_Speed_copy;
            uniform float _Disturbance;
            uniform float _Alpha;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
                float4 node_9982 = _Time + _TimeEditor;
                float4 node_9955 = _Time + _TimeEditor;
                float2 node_2778 = float2(((node_9982.g*_U_Speed)+i.uv0.r),(i.uv0.g+(node_9955.g*_V_Speed)));
                float4 _Noise01_var = tex2D(_Noise01,TRANSFORM_TEX(node_2778, _Noise01));
                float4 node_1896 = _Time + _TimeEditor;
                float4 node_8589 = _Time + _TimeEditor;
                float2 node_9617 = float2(((node_1896.g*_U_Speed_copy)+i.uv0.r),(i.uv0.g+(node_8589.g*_V_Speed_copy)));
                float4 _Noise02_var = tex2D(_Noise02,TRANSFORM_TEX(node_9617, _Noise02));
                float2 node_1540 = (i.uv0+((_Noise01_var.rgb*_Noise02_var.rgb).r*_Disturbance));
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(node_1540, _MainTex));
                float3 emissive = (_ZT*i.vertexColor.rgb*_TintColor.rgb*_MainTex_var.rgb);
                float3 finalColor = emissive;
                return fixed4(finalColor,(i.vertexColor.a*_TintColor.a*_MainTex_var.a*_Alpha));
            }
            ENDCG
        }
    }
    CustomEditor "ShaderForgeMaterialInspector"
}
