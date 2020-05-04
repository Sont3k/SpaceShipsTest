Shader "Custom/WindShader" {
    Properties {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
        
        _WindFrequency("Wind Frequency",Range(0.001,100)) = 1
        _WindStrength("Wind Strength", Range( 0, 2 )) = 0.3
        _WindGustDistance("Distance between gusts",Range(0.001,50)) = .25
        _WindDirection("Wind Direction", vector) = (1,0, 1,0)
    }
    SubShader {
        Tags { 
            "Queue"="Transparent"
            "RenderType"="TransparentCutout"
        }
        LOD 200
        
        CGPROGRAM
        
        #pragma surface surf Standard vertex:vert alpha:fade
        
        sampler2D _MainTex;
        
        struct Input {
            float2 uv_MainTex;
        };
        
        half _Glossiness;
        half _Metallic;
        fixed4 _Color;
        
        half _WindFrequency;
        half _WindGustDistance;
        half _WindStrength;
        float3 _WindDirection;
        
        void vert( inout appdata_full v )
        {
            float4 localSpaceVertex = v.vertex;
            float4 worldSpaceVertex = mul( unity_ObjectToWorld, localSpaceVertex );
            
            float height = (localSpaceVertex.y/2 + .5);
            
            worldSpaceVertex.x += sin( _Time.x * _WindFrequency + worldSpaceVertex.x * _WindGustDistance) * height * _WindStrength * _WindDirection.x;
            worldSpaceVertex.z += sin( _Time.x * _WindFrequency + worldSpaceVertex.z * _WindGustDistance) * height * _WindStrength * _WindDirection.z;
            
            v.vertex = mul( unity_WorldToObject, worldSpaceVertex );
        }
        
        void surf (Input IN, inout SurfaceOutputStandard o) {
            fixed4 c = tex2D (_MainTex, IN.uv_MainTex) * _Color;
            
            o.Albedo = c.rgb;
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            o.Alpha = c.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}