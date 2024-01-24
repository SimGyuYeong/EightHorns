Shader "ImageEffect/ShadowThresholdCustomEffect"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _ShadowThreshold ("My float", Float) = 0.5 
    }
    SubShader
    {
        // No culling or depth
        Cull Off ZWrite Off ZTest Always

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            sampler2D _MainTex;
             float _MyFloat;

            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 col = tex2D(_MainTex, i.uv);
                half4 tex=col;
                float luminance=(col.r*0.29+col.g*0.59+col.b*0.12);
                if(luminance>_MyFloat)
                {
                col.rgb=1;
                }else
                {
                col.rgb=0;
                }
                 col.rgb=lerp(col.rgb,tex.rgb,col.r);
                return col;
            }
            ENDCG
        }
    }
}