// Shader created with Shader Forge v1.38 
// Shader Forge (c) Freya Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:0,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:1,bsrc:0,bdst:1,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:32719,y:32712,varname:node_2865,prsc:2|diff-4199-OUT,spec-2214-OUT,gloss-5062-OUT,normal-9697-RGB,emission-2465-OUT,amdfl-3845-RGB;n:type:ShaderForge.SFN_NormalVector,id:9882,x:28949,y:32487,prsc:2,pt:False;n:type:ShaderForge.SFN_ComponentMask,id:5772,x:29361,y:32487,varname:node_5772,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-923-OUT;n:type:ShaderForge.SFN_Multiply,id:4219,x:29582,y:32487,varname:node_4219,prsc:2|A-5772-OUT,B-5222-OUT;n:type:ShaderForge.SFN_Add,id:1463,x:29772,y:32487,varname:node_1463,prsc:2|A-1883-UVOUT,B-4219-OUT;n:type:ShaderForge.SFN_ScreenPos,id:1883,x:29573,y:32839,varname:node_1883,prsc:2,sctp:2;n:type:ShaderForge.SFN_Fresnel,id:5222,x:29171,y:32678,varname:node_5222,prsc:2|EXP-6274-OUT;n:type:ShaderForge.SFN_Slider,id:6274,x:28820,y:32697,ptovrint:False,ptlb:Distortion,ptin:_Distortion,varname:_Distortion,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:5.3,max:20;n:type:ShaderForge.SFN_SceneColor,id:7157,x:31078,y:32329,varname:node_7157,prsc:2|UVIN-895-OUT;n:type:ShaderForge.SFN_Slider,id:2136,x:32139,y:32699,ptovrint:False,ptlb:Specular,ptin:_Specular,varname:_Specular,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4,max:1;n:type:ShaderForge.SFN_Slider,id:5062,x:32212,y:33156,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:_Gloss,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.96,max:1;n:type:ShaderForge.SFN_Color,id:4649,x:31424,y:33357,ptovrint:False,ptlb:Reflection_Color,ptin:_Reflection_Color,varname:_Reflection_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:3712,x:32149,y:32508,varname:node_3712,prsc:2|A-7167-OUT,B-1599-RGB;n:type:ShaderForge.SFN_ComponentMask,id:4754,x:31188,y:33675,varname:node_4754,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-9313-OUT;n:type:ShaderForge.SFN_Slider,id:7012,x:31057,y:33927,ptovrint:False,ptlb:Matcap_Scale,ptin:_Matcap_Scale,varname:_Matcap_Scale,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.5,max:5;n:type:ShaderForge.SFN_Multiply,id:5158,x:31420,y:33729,varname:node_5158,prsc:2|A-4754-OUT,B-7012-OUT;n:type:ShaderForge.SFN_Add,id:9732,x:31691,y:33799,varname:node_9732,prsc:2|A-5158-OUT,B-7012-OUT;n:type:ShaderForge.SFN_Tex2d,id:9443,x:31868,y:33679,ptovrint:False,ptlb:Matcap,ptin:_Matcap,varname:_Matcap,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:b906817369d69ef47941d7d9ca264564,ntxv:2,isnm:False|UVIN-9732-OUT;n:type:ShaderForge.SFN_Multiply,id:2465,x:32199,y:33623,varname:node_2465,prsc:2|A-9443-RGB,B-720-OUT,C-4745-OUT;n:type:ShaderForge.SFN_Multiply,id:720,x:31657,y:33986,varname:node_720,prsc:2|A-4649-RGB,B-4095-OUT;n:type:ShaderForge.SFN_Slider,id:4095,x:31305,y:34057,ptovrint:False,ptlb:Matcap_Strength,ptin:_Matcap_Strength,varname:_Matcap_Strength,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.18,max:1;n:type:ShaderForge.SFN_Color,id:3717,x:31444,y:34261,ptovrint:False,ptlb:Emission_Base_Color,ptin:_Emission_Base_Color,varname:_Emission_Base_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Color,id:6529,x:32152,y:32350,ptovrint:False,ptlb:Albedo_Base_Color,ptin:_Albedo_Base_Color,varname:_Albedo_Base_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Add,id:4199,x:32393,y:32360,varname:node_4199,prsc:2|A-6529-RGB,B-3712-OUT;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:4639,x:31257,y:34469,varname:node_4639,prsc:2|IN-282-OUT,IMIN-5329-OUT,IMAX-9014-OUT,OMIN-3553-OUT,OMAX-8510-OUT;n:type:ShaderForge.SFN_Vector1,id:5329,x:31000,y:34484,varname:node_5329,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:9014,x:31000,y:34537,varname:node_9014,prsc:2,v1:1;n:type:ShaderForge.SFN_Vector1,id:8510,x:31061,y:34689,varname:node_8510,prsc:2,v1:1;n:type:ShaderForge.SFN_Power,id:8074,x:31449,y:34528,varname:node_8074,prsc:2|VAL-4639-OUT,EXP-3076-OUT;n:type:ShaderForge.SFN_Vector1,id:3076,x:31255,y:34719,varname:node_3076,prsc:2,v1:0.5;n:type:ShaderForge.SFN_Slider,id:3553,x:30778,y:34664,ptovrint:False,ptlb:Matcap_Emission_Bottom,ptin:_Matcap_Emission_Bottom,varname:_Matcap_Emission_Bottom,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.01,max:1;n:type:ShaderForge.SFN_Multiply,id:901,x:31614,y:34368,varname:node_901,prsc:2|A-3717-RGB,B-8074-OUT;n:type:ShaderForge.SFN_Color,id:3573,x:31750,y:33527,ptovrint:False,ptlb:Color,ptin:_Color,varname:_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:0.03921569;n:type:ShaderForge.SFN_Color,id:1599,x:31822,y:32629,ptovrint:False,ptlb:Incident_Color,ptin:_Incident_Color,varname:_Incident_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Multiply,id:2214,x:32493,y:32723,varname:node_2214,prsc:2|A-2136-OUT,B-4649-RGB;n:type:ShaderForge.SFN_Tex2d,id:9697,x:32353,y:32972,ptovrint:False,ptlb:Normal Map,ptin:_NormalMap,varname:_NormalMap,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:3,isnm:True;n:type:ShaderForge.SFN_ViewReflectionVector,id:4825,x:30686,y:33609,varname:node_4825,prsc:2;n:type:ShaderForge.SFN_AmbientLight,id:3221,x:30363,y:34549,varname:node_3221,prsc:2;n:type:ShaderForge.SFN_LightColor,id:549,x:30527,y:34569,varname:node_549,prsc:2;n:type:ShaderForge.SFN_Add,id:9637,x:30569,y:34340,varname:node_9637,prsc:2|A-3756-OUT,B-1448-RGB,C-3221-RGB;n:type:ShaderForge.SFN_Multiply,id:282,x:30798,y:34402,varname:node_282,prsc:2|A-9637-OUT,B-549-RGB;n:type:ShaderForge.SFN_Add,id:4745,x:31786,y:34452,varname:node_4745,prsc:2|A-901-OUT,B-8074-OUT;n:type:ShaderForge.SFN_SceneColor,id:1448,x:30363,y:34419,varname:node_1448,prsc:2;n:type:ShaderForge.SFN_Dot,id:458,x:29659,y:34139,varname:node_458,prsc:2,dt:1|A-3406-OUT,B-3839-OUT;n:type:ShaderForge.SFN_NormalVector,id:3406,x:29490,y:34091,prsc:2,pt:False;n:type:ShaderForge.SFN_LightVector,id:3839,x:29490,y:34233,varname:node_3839,prsc:2;n:type:ShaderForge.SFN_ViewReflectionVector,id:8565,x:29490,y:34353,varname:node_8565,prsc:2;n:type:ShaderForge.SFN_Dot,id:7155,x:29659,y:34289,varname:node_7155,prsc:2,dt:1|A-3839-OUT,B-8565-OUT;n:type:ShaderForge.SFN_Add,id:3756,x:30035,y:34191,varname:node_3756,prsc:2|A-458-OUT,B-5851-OUT;n:type:ShaderForge.SFN_Exp,id:8668,x:29659,y:34489,varname:node_8668,prsc:2,et:1|IN-3324-OUT;n:type:ShaderForge.SFN_Power,id:5851,x:29858,y:34327,varname:node_5851,prsc:2|VAL-7155-OUT,EXP-8668-OUT;n:type:ShaderForge.SFN_Vector1,id:3324,x:29490,y:34533,varname:node_3324,prsc:2,v1:2;n:type:ShaderForge.SFN_Transform,id:4004,x:30840,y:33685,varname:node_4004,prsc:2,tffrom:0,tfto:3|IN-4825-OUT;n:type:ShaderForge.SFN_SwitchProperty,id:9313,x:31023,y:33586,ptovrint:False,ptlb:Matcap Style,ptin:_MatcapStyle,varname:_MatcapStyle,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:False|A-4825-OUT,B-4004-XYZ;n:type:ShaderForge.SFN_Negate,id:923,x:29160,y:32487,varname:node_923,prsc:2|IN-9882-OUT;n:type:ShaderForge.SFN_Color,id:3845,x:31931,y:32790,ptovrint:False,ptlb:Glass_Color,ptin:_Glass_Color,varname:node_3845,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:1,c3:1,c4:1;n:type:ShaderForge.SFN_Tex2d,id:3305,x:31131,y:31978,ptovrint:False,ptlb:Texture,ptin:_Texture,varname:node_3305,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,ntxv:2,isnm:False|UVIN-8665-OUT;n:type:ShaderForge.SFN_Multiply,id:1909,x:31620,y:32207,varname:node_1909,prsc:2|A-3305-RGB,B-3049-OUT,C-3305-A;n:type:ShaderForge.SFN_Multiply,id:6789,x:31620,y:32370,varname:node_6789,prsc:2|A-7157-RGB,B-2169-OUT,C-3049-OUT;n:type:ShaderForge.SFN_Slider,id:5954,x:30923,y:32706,ptovrint:False,ptlb:Texture Opacity,ptin:_TextureOpacity,varname:node_5954,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_RemapRange,id:3049,x:31277,y:32483,varname:node_3049,prsc:2,frmn:0,frmx:1,tomn:1,tomx:0|IN-5954-OUT;n:type:ShaderForge.SFN_Multiply,id:1237,x:31620,y:32508,varname:node_1237,prsc:2|A-7157-RGB,B-5954-OUT;n:type:ShaderForge.SFN_RemapRange,id:2169,x:31309,y:32203,varname:node_2169,prsc:2,frmn:0,frmx:1,tomn:1,tomx:0|IN-3305-A;n:type:ShaderForge.SFN_Add,id:7167,x:31820,y:32381,varname:node_7167,prsc:2|A-1909-OUT,B-6789-OUT,C-1237-OUT;n:type:ShaderForge.SFN_ToggleProperty,id:4837,x:29573,y:32693,ptovrint:False,ptlb:Use_Distortion,ptin:_Use_Distortion,varname:node_4837,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,on:True;n:type:ShaderForge.SFN_Multiply,id:5858,x:29960,y:32524,varname:node_5858,prsc:2|A-1463-OUT,B-4837-OUT;n:type:ShaderForge.SFN_Multiply,id:1230,x:29960,y:32728,varname:node_1230,prsc:2|A-8313-OUT,B-1883-UVOUT;n:type:ShaderForge.SFN_OneMinus,id:8313,x:29772,y:32728,varname:node_8313,prsc:2|IN-4837-OUT;n:type:ShaderForge.SFN_Add,id:895,x:30813,y:32325,varname:node_895,prsc:2|A-1230-OUT,B-5858-OUT;n:type:ShaderForge.SFN_TexCoord,id:914,x:29992,y:31794,varname:node_914,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:9873,x:30459,y:31934,varname:node_9873,prsc:2|A-914-UVOUT,B-3073-OUT;n:type:ShaderForge.SFN_Multiply,id:6859,x:30646,y:31987,varname:node_6859,prsc:2|A-9873-OUT,B-4837-OUT;n:type:ShaderForge.SFN_Multiply,id:5843,x:30646,y:32121,varname:node_5843,prsc:2|A-914-UVOUT,B-8313-OUT;n:type:ShaderForge.SFN_Add,id:8665,x:30866,y:32010,varname:node_8665,prsc:2|A-6859-OUT,B-5843-OUT;n:type:ShaderForge.SFN_Transform,id:7874,x:29365,y:32214,varname:node_7874,prsc:2,tffrom:0,tfto:3|IN-923-OUT;n:type:ShaderForge.SFN_ComponentMask,id:7424,x:29529,y:32214,varname:node_7424,prsc:2,cc1:0,cc2:1,cc3:-1,cc4:-1|IN-7874-XYZ;n:type:ShaderForge.SFN_Multiply,id:3073,x:29760,y:32304,varname:node_3073,prsc:2|A-7424-OUT,B-5222-OUT;proporder:4837-6274-6529-3845-1599-4649-2136-5062-3717-9443-9313-7012-4095-3553-9697-3305-5954-3573;pass:END;sub:END;*/

Shader "Shader Forge/oy_GlassSphere(VRCSafety:Particle)" {
    Properties {
        [MaterialToggle] _Use_Distortion ("Use_Distortion", Float ) = 1
        _Distortion ("Distortion", Range(0, 20)) = 5.3
        _Albedo_Base_Color ("Albedo_Base_Color", Color) = (0,0,0,1)
        _Glass_Color ("Glass_Color", Color) = (1,1,1,1)
        _Incident_Color ("Incident_Color", Color) = (1,1,1,1)
        _Reflection_Color ("Reflection_Color", Color) = (1,1,1,1)
        _Specular ("Specular", Range(0, 1)) = 0.4
        _Gloss ("Gloss", Range(0, 1)) = 0.96
        _Emission_Base_Color ("Emission_Base_Color", Color) = (0,0,0,1)
        _Matcap ("Matcap", 2D) = "black" {}
        [MaterialToggle] _MatcapStyle ("Matcap Style", Float ) = 0
        _Matcap_Scale ("Matcap_Scale", Range(0, 5)) = 0.5
        _Matcap_Strength ("Matcap_Strength", Range(0, 1)) = 0.18
        _Matcap_Emission_Bottom ("Matcap_Emission_Bottom", Range(0, 1)) = 0.01
        _NormalMap ("Normal Map", 2D) = "bump" {}
        _Texture ("Texture", 2D) = "black" {}
        _TextureOpacity ("Texture Opacity", Range(0, 1)) = 0
        _Color ("Color", Color) = (0.5,0.5,0.5,0.03921569)
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        GrabPass{ }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Cull Front
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform float _Distortion;
            uniform float _Specular;
            uniform float _Gloss;
            uniform float4 _Reflection_Color;
            uniform float _Matcap_Scale;
            uniform sampler2D _Matcap; uniform float4 _Matcap_ST;
            uniform float _Matcap_Strength;
            uniform float4 _Emission_Base_Color;
            uniform float4 _Albedo_Base_Color;
            uniform float _Matcap_Emission_Bottom;
            uniform float4 _Incident_Color;
            uniform sampler2D _NormalMap; uniform float4 _NormalMap_ST;
            uniform fixed _MatcapStyle;
            uniform float4 _Glass_Color;
            uniform sampler2D _Texture; uniform float4 _Texture_ST;
            uniform float _TextureOpacity;
            uniform fixed _Use_Distortion;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                float4 projPos : TEXCOORD7;
                UNITY_FOG_COORDS(8)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD9;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #elif UNITY_SHOULD_SAMPLE_SH
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(-v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _NormalMap_var = UnpackNormal(tex2D(_NormalMap,TRANSFORM_TEX(i.uv0, _NormalMap)));
                float3 normalLocal = _NormalMap_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _Gloss;
                float perceptualRoughness = 1.0 - _Gloss;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                    d.ambient = 0;
                    d.lightmapUV = i.ambientOrLightmapUV;
                #else
                    d.ambient = i.ambientOrLightmapUV;
                #endif
                #if UNITY_SPECCUBE_BLENDING || UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMin[0] = unity_SpecCube0_BoxMin;
                    d.boxMin[1] = unity_SpecCube1_BoxMin;
                #endif
                #if UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMax[0] = unity_SpecCube0_BoxMax;
                    d.boxMax[1] = unity_SpecCube1_BoxMax;
                    d.probePosition[0] = unity_SpecCube0_ProbePosition;
                    d.probePosition[1] = unity_SpecCube1_ProbePosition;
                #endif
                d.probeHDR[0] = unity_SpecCube0_HDR;
                d.probeHDR[1] = unity_SpecCube1_HDR;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = (_Specular*_Reflection_Color.rgb);
                float specularMonochrome;
                float3 node_923 = (-1*i.normalDir);
                float node_5222 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_Distortion);
                float node_8313 = (1.0 - _Use_Distortion);
                float2 node_8665 = (((i.uv0+(mul( UNITY_MATRIX_V, float4(node_923,0) ).xyz.rgb.rg*node_5222))*_Use_Distortion)+(i.uv0*node_8313));
                float4 _Texture_var = tex2D(_Texture,TRANSFORM_TEX(node_8665, _Texture));
                float node_3049 = (_TextureOpacity*-1.0+1.0);
                float4 node_7157 = tex2D( _GrabTexture, ((node_8313*sceneUVs.rg)+((sceneUVs.rg+(node_923.rg*node_5222))*_Use_Distortion)));
                float3 diffuseColor = (_Albedo_Base_Color.rgb+(((_Texture_var.rgb*node_3049*_Texture_var.a)+(node_7157.rgb*(_Texture_var.a*-1.0+1.0)*node_3049)+(node_7157.rgb*_TextureOpacity))*_Incident_Color.rgb)); // Need this for specular when using metallic
                diffuseColor = EnergyConservationBetweenDiffuseAndSpecular(diffuseColor, specularColor, specularMonochrome);
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                half surfaceReduction;
                #ifdef UNITY_COLORSPACE_GAMMA
                    surfaceReduction = 1.0-0.28*roughness*perceptualRoughness;
                #else
                    surfaceReduction = 1.0/(roughness*roughness + 1.0);
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                half grazingTerm = saturate( gloss + specularMonochrome );
                float3 indirectSpecular = (gi.indirect.specular);
                indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
                indirectSpecular *= surfaceReduction;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += _Glass_Color.rgb; // Diffuse Ambient Light
                indirectDiffuse += gi.indirect.diffuse;
                diffuseColor *= 1-specularMonochrome;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
////// Emissive:
                float2 node_9732 = ((lerp( viewReflectDirection, mul( UNITY_MATRIX_V, float4(viewReflectDirection,0) ).xyz.rgb, _MatcapStyle ).rg*_Matcap_Scale)+_Matcap_Scale);
                float4 _Matcap_var = tex2D(_Matcap,TRANSFORM_TEX(node_9732, _Matcap));
                float node_5329 = 0.0;
                float3 node_8074 = pow((_Matcap_Emission_Bottom + ( ((((max(0,dot(i.normalDir,lightDirection))+pow(max(0,dot(lightDirection,viewReflectDirection)),exp2(2.0)))+sceneColor.rgb+UNITY_LIGHTMODEL_AMBIENT.rgb)*_LightColor0.rgb) - node_5329) * (1.0 - _Matcap_Emission_Bottom) ) / (1.0 - node_5329)),0.5);
                float3 emissive = (_Matcap_var.rgb*(_Reflection_Color.rgb*_Matcap_Strength)*((_Emission_Base_Color.rgb*node_8074)+node_8074));
/// Final Color:
                float3 finalColor = diffuse + specular + emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            Cull Front
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform float _Distortion;
            uniform float _Specular;
            uniform float _Gloss;
            uniform float4 _Reflection_Color;
            uniform float _Matcap_Scale;
            uniform sampler2D _Matcap; uniform float4 _Matcap_ST;
            uniform float _Matcap_Strength;
            uniform float4 _Emission_Base_Color;
            uniform float4 _Albedo_Base_Color;
            uniform float _Matcap_Emission_Bottom;
            uniform float4 _Incident_Color;
            uniform sampler2D _NormalMap; uniform float4 _NormalMap_ST;
            uniform fixed _MatcapStyle;
            uniform sampler2D _Texture; uniform float4 _Texture_ST;
            uniform float _TextureOpacity;
            uniform fixed _Use_Distortion;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                float4 projPos : TEXCOORD7;
                LIGHTING_COORDS(8,9)
                UNITY_FOG_COORDS(10)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(-v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 _NormalMap_var = UnpackNormal(tex2D(_NormalMap,TRANSFORM_TEX(i.uv0, _NormalMap)));
                float3 normalLocal = _NormalMap_var.rgb;
                float3 normalDirection = normalize(mul( normalLocal, tangentTransform )); // Perturbed normals
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = _Gloss;
                float perceptualRoughness = 1.0 - _Gloss;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = (_Specular*_Reflection_Color.rgb);
                float specularMonochrome;
                float3 node_923 = (-1*i.normalDir);
                float node_5222 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_Distortion);
                float node_8313 = (1.0 - _Use_Distortion);
                float2 node_8665 = (((i.uv0+(mul( UNITY_MATRIX_V, float4(node_923,0) ).xyz.rgb.rg*node_5222))*_Use_Distortion)+(i.uv0*node_8313));
                float4 _Texture_var = tex2D(_Texture,TRANSFORM_TEX(node_8665, _Texture));
                float node_3049 = (_TextureOpacity*-1.0+1.0);
                float4 node_7157 = tex2D( _GrabTexture, ((node_8313*sceneUVs.rg)+((sceneUVs.rg+(node_923.rg*node_5222))*_Use_Distortion)));
                float3 diffuseColor = (_Albedo_Base_Color.rgb+(((_Texture_var.rgb*node_3049*_Texture_var.a)+(node_7157.rgb*(_Texture_var.a*-1.0+1.0)*node_3049)+(node_7157.rgb*_TextureOpacity))*_Incident_Color.rgb)); // Need this for specular when using metallic
                diffuseColor = EnergyConservationBetweenDiffuseAndSpecular(diffuseColor, specularColor, specularMonochrome);
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                diffuseColor *= 1-specularMonochrome;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                fixed4 finalRGBA = fixed4(finalColor * 1,0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Front
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 3.0
            uniform sampler2D _GrabTexture;
            uniform float _Distortion;
            uniform float _Specular;
            uniform float _Gloss;
            uniform float4 _Reflection_Color;
            uniform float _Matcap_Scale;
            uniform sampler2D _Matcap; uniform float4 _Matcap_ST;
            uniform float _Matcap_Strength;
            uniform float4 _Emission_Base_Color;
            uniform float4 _Albedo_Base_Color;
            uniform float _Matcap_Emission_Bottom;
            uniform float4 _Incident_Color;
            uniform fixed _MatcapStyle;
            uniform sampler2D _Texture; uniform float4 _Texture_ST;
            uniform float _TextureOpacity;
            uniform fixed _Use_Distortion;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(-v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            float4 frag(VertexOutput i) : SV_Target {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float2 sceneUVs = (i.projPos.xy / i.projPos.w);
                float4 sceneColor = tex2D(_GrabTexture, sceneUVs);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                float2 node_9732 = ((lerp( viewReflectDirection, mul( UNITY_MATRIX_V, float4(viewReflectDirection,0) ).xyz.rgb, _MatcapStyle ).rg*_Matcap_Scale)+_Matcap_Scale);
                float4 _Matcap_var = tex2D(_Matcap,TRANSFORM_TEX(node_9732, _Matcap));
                float node_5329 = 0.0;
                float3 node_8074 = pow((_Matcap_Emission_Bottom + ( ((((max(0,dot(i.normalDir,lightDirection))+pow(max(0,dot(lightDirection,viewReflectDirection)),exp2(2.0)))+sceneColor.rgb+UNITY_LIGHTMODEL_AMBIENT.rgb)*_LightColor0.rgb) - node_5329) * (1.0 - _Matcap_Emission_Bottom) ) / (1.0 - node_5329)),0.5);
                o.Emission = (_Matcap_var.rgb*(_Reflection_Color.rgb*_Matcap_Strength)*((_Emission_Base_Color.rgb*node_8074)+node_8074));
                
                float3 node_923 = (-1*i.normalDir);
                float node_5222 = pow(1.0-max(0,dot(normalDirection, viewDirection)),_Distortion);
                float node_8313 = (1.0 - _Use_Distortion);
                float2 node_8665 = (((i.uv0+(mul( UNITY_MATRIX_V, float4(node_923,0) ).xyz.rgb.rg*node_5222))*_Use_Distortion)+(i.uv0*node_8313));
                float4 _Texture_var = tex2D(_Texture,TRANSFORM_TEX(node_8665, _Texture));
                float node_3049 = (_TextureOpacity*-1.0+1.0);
                float4 node_7157 = tex2D( _GrabTexture, ((node_8313*sceneUVs.rg)+((sceneUVs.rg+(node_923.rg*node_5222))*_Use_Distortion)));
                float3 diffColor = (_Albedo_Base_Color.rgb+(((_Texture_var.rgb*node_3049*_Texture_var.a)+(node_7157.rgb*(_Texture_var.a*-1.0+1.0)*node_3049)+(node_7157.rgb*_TextureOpacity))*_Incident_Color.rgb));
                float3 specColor = (_Specular*_Reflection_Color.rgb);
                float specularMonochrome = max(max(specColor.r, specColor.g),specColor.b);
                diffColor *= (1.0-specularMonochrome);
                float roughness = 1.0 - _Gloss;
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
