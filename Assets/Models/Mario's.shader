Shader "Unlit/Mario's"
{
	Properties {
	_Test ("First", Color)=(1,1,1,1)
	_Texture("Texture",2D)="white"{}
	}

	SubShader {
		Pass {
			CGPROGRAM
				#pragma vertex vertexFunction
				#pragma fragment fragmentFunction

				#include "UnityCG.cginc"

				struct appdata {
					float4 vertex : POSITION;
					float2 uv : TEXCOORD0;
				};

				struct v2f {
					float4 position : SV_POSITION;
					float2 uv : TEXCOORD0;
				};


				//Get our properties into CG
				float4 _Test;
				sampler2D _Texture;
				v2f vertexFunction (appdata IN) {
					v2f OUT;
					OUT.position = UnityObjectToClipPos(IN.vertex);
					OUT.uv=IN.uv;
					return OUT;
				}

				fixed4 fragmentFunction (v2f IN) : SV_TARGET {
				//return _Test; //(R, G, B, A)
				return tex2D(_Texture,IN.uv);
				}
			ENDCG
		}
	}
}
