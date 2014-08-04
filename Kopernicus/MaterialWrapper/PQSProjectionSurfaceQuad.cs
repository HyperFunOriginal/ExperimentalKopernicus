// Material wrapper generated by shader translator tool
using System;
using System.Reflection;
using UnityEngine;

namespace Kopernicus
{
    namespace MaterialWrapper
    {
        public class PQSProjectionSurfaceQuad : Material
        {
            // Return the shader for this wrapper
            private const string shaderName = "Terrain/PQS/Sphere Projection SURFACE QUAD";
            private static Shader shaderForMaterial
            {
                get { return Shader.Find (shaderName); }
            }

            // Saturation, default = 1
            private const string saturationKey = "_saturation";
            public float saturation
            {
                get { return GetFloat (saturationKey); }
                set { SetFloat (saturationKey, value); }
            }

            // Contrast, default = 1
            private const string contrastKey = "_contrast";
            public float contrast
            {
                get { return GetFloat (contrastKey); }
                set { SetFloat (contrastKey, value); }
            }

            // Colour Unsaturation (A = Factor), default = (1,1,1,0)
            private const string tintColorKey = "_tintColor";
            public Color tintColor
            {
                get { return GetColor (tintColorKey); }
                set { SetColor (tintColorKey, value); }
            }

            // Near Tiling, default = 1000
            private const string texTilingKey = "_texTiling";
            public float texTiling
            {
                get { return GetFloat (texTilingKey); }
                set { SetFloat (texTilingKey, value); }
            }

            // Near Blend, default = 0.5
            private const string texPowerKey = "_texPower";
            public float texPower
            {
                get { return GetFloat (texPowerKey); }
                set { SetFloat (texPowerKey, value); }
            }

            // Far Blend, default = 0.5
            private const string multiPowerKey = "_multiPower";
            public float multiPower
            {
                get { return GetFloat (multiPowerKey); }
                set { SetFloat (multiPowerKey, value); }
            }

            // NearFar Start, default = 2000
            private const string groundTexStartKey = "_groundTexStart";
            public float groundTexStart
            {
                get { return GetFloat (groundTexStartKey); }
                set { SetFloat (groundTexStartKey, value); }
            }

            // NearFar Start, default = 10000
            private const string groundTexEndKey = "_groundTexEnd";
            public float groundTexEnd
            {
                get { return GetFloat (groundTexEndKey); }
                set { SetFloat (groundTexEndKey, value); }
            }

            // Steep Tiling, default = 1
            private const string steepTilingKey = "_steepTiling";
            public float steepTiling
            {
                get { return GetFloat (steepTilingKey); }
                set { SetFloat (steepTilingKey, value); }
            }

            // Steep Blend, default = 1
            private const string steepPowerKey = "_steepPower";
            public float steepPower
            {
                get { return GetFloat (steepPowerKey); }
                set { SetFloat (steepPowerKey, value); }
            }

            // Steep Fade Start, default = 20000
            private const string steepTexStartKey = "_steepTexStart";
            public float steepTexStart
            {
                get { return GetFloat (steepTexStartKey); }
                set { SetFloat (steepTexStartKey, value); }
            }

            // Steep Fade End, default = 30000
            private const string steepTexEndKey = "_steepTexEnd";
            public float steepTexEnd
            {
                get { return GetFloat (steepTexEndKey); }
                set { SetFloat (steepTexEndKey, value); }
            }

            // Deep ground, default = "white" {}
            private const string deepTexKey = "_deepTex";
            public Texture2D deepTex
            {
                get { return GetTexture (deepTexKey) as Texture2D; }
                set { SetTexture (deepTexKey, value); }
            }

            // Deep MT, default = "white" {}
            private const string deepMultiTexKey = "_deepMultiTex";
            public Texture2D deepMultiTex
            {
                get { return GetTexture (deepMultiTexKey) as Texture2D; }
                set { SetTexture (deepMultiTexKey, value); }
            }

            // Deep MT Tiling, default = 1
            private const string deepMultiFactorKey = "_deepMultiFactor";
            public float deepMultiFactor
            {
                get { return GetFloat (deepMultiFactorKey); }
                set { SetFloat (deepMultiFactorKey, value); }
            }

            // Main Texture, default = "white" {}
            private const string mainTexKey = "_mainTex";
            public Texture2D mainTex
            {
                get { return GetTexture (mainTexKey) as Texture2D; }
                set { SetTexture (mainTexKey, value); }
            }

            // Main MT, default = "white" {}
            private const string mainMultiTexKey = "_mainMultiTex";
            public Texture2D mainMultiTex
            {
                get { return GetTexture (mainMultiTexKey) as Texture2D; }
                set { SetTexture (mainMultiTexKey, value); }
            }

            // Main MT Tiling, default = 1
            private const string mainMultiFactorKey = "_mainMultiFactor";
            public float mainMultiFactor
            {
                get { return GetFloat (mainMultiFactorKey); }
                set { SetFloat (mainMultiFactorKey, value); }
            }

            // High Ground, default = "white" {}
            private const string highTexKey = "_highTex";
            public Texture2D highTex
            {
                get { return GetTexture (highTexKey) as Texture2D; }
                set { SetTexture (highTexKey, value); }
            }

            // High MT, default = "white" {}
            private const string highMultiTexKey = "_highMultiTex";
            public Texture2D highMultiTex
            {
                get { return GetTexture (highMultiTexKey) as Texture2D; }
                set { SetTexture (highMultiTexKey, value); }
            }

            // High MT Tiling, default = 1
            private const string highMultiFactorKey = "_highMultiFactor";
            public float highMultiFactor
            {
                get { return GetFloat (highMultiFactorKey); }
                set { SetFloat (highMultiFactorKey, value); }
            }

            // Snow, default = "white" {}
            private const string snowTexKey = "_snowTex";
            public Texture2D snowTex
            {
                get { return GetTexture (snowTexKey) as Texture2D; }
                set { SetTexture (snowTexKey, value); }
            }

            // Snow MT, default = "white" {}
            private const string snowMultiTexKey = "_snowMultiTex";
            public Texture2D snowMultiTex
            {
                get { return GetTexture (snowMultiTexKey) as Texture2D; }
                set { SetTexture (snowMultiTexKey, value); }
            }

            // Snow MT Tiling, default = 1
            private const string snowMultiFactorKey = "_snowMultiFactor";
            public float snowMultiFactor
            {
                get { return GetFloat (snowMultiFactorKey); }
                set { SetFloat (snowMultiFactorKey, value); }
            }

            // Steep Texture, default = "white" {}
            private const string steepTexKey = "_steepTex";
            public Texture2D steepTex
            {
                get { return GetTexture (steepTexKey) as Texture2D; }
                set { SetTexture (steepTexKey, value); }
            }

            // Deep Start, default = 0
            private const string deepStartKey = "_deepStart";
            public float deepStart
            {
                get { return GetFloat (deepStartKey); }
                set { SetFloat (deepStartKey, value); }
            }

            // Deep End, default = 0.3
            private const string deepEndKey = "_deepEnd";
            public float deepEnd
            {
                get { return GetFloat (deepEndKey); }
                set { SetFloat (deepEndKey, value); }
            }

            // Main lower boundary start, default = 0
            private const string mainLoStartKey = "_mainLoStart";
            public float mainLoStart
            {
                get { return GetFloat (mainLoStartKey); }
                set { SetFloat (mainLoStartKey, value); }
            }

            // Main lower boundary end, default = 0.5
            private const string mainLoEndKey = "_mainLoEnd";
            public float mainLoEnd
            {
                get { return GetFloat (mainLoEndKey); }
                set { SetFloat (mainLoEndKey, value); }
            }

            // Main upper boundary start, default = 0.3
            private const string mainHiStartKey = "_mainHiStart";
            public float mainHiStart
            {
                get { return GetFloat (mainHiStartKey); }
                set { SetFloat (mainHiStartKey, value); }
            }

            // Main upper boundary end, default = 0.5
            private const string mainHiEndKey = "_mainHiEnd";
            public float mainHiEnd
            {
                get { return GetFloat (mainHiEndKey); }
                set { SetFloat (mainHiEndKey, value); }
            }

            // High lower boundary start, default = 0.6
            private const string hiLoStartKey = "_hiLoStart";
            public float hiLoStart
            {
                get { return GetFloat (hiLoStartKey); }
                set { SetFloat (hiLoStartKey, value); }
            }

            // High lower boundary end, default = 0.6
            private const string hiLoEndKey = "_hiLoEnd";
            public float hiLoEnd
            {
                get { return GetFloat (hiLoEndKey); }
                set { SetFloat (hiLoEndKey, value); }
            }

            // High upper boundary start, default = 0.6
            private const string hiHiStartKey = "_hiHiStart";
            public float hiHiStart
            {
                get { return GetFloat (hiHiStartKey); }
                set { SetFloat (hiHiStartKey, value); }
            }

            // High upper boundary end, default = 0.9
            private const string hiHiEndKey = "_hiHiEnd";
            public float hiHiEnd
            {
                get { return GetFloat (hiHiEndKey); }
                set { SetFloat (hiHiEndKey, value); }
            }

            // Snow Start, default = 0.9
            private const string snowStartKey = "_snowStart";
            public float snowStart
            {
                get { return GetFloat (snowStartKey); }
                set { SetFloat (snowStartKey, value); }
            }

            // Snow End, default = 1
            private const string snowEndKey = "_snowEnd";
            public float snowEnd
            {
                get { return GetFloat (snowEndKey); }
                set { SetFloat (snowEndKey, value); }
            }

            // PlanetOpacity, default = 1
            private const string planetOpacityKey = "_PlanetOpacity";
            public float planetOpacity
            {
                get { return GetFloat (planetOpacityKey); }
                set { SetFloat (planetOpacityKey, value); }
            }

            public PQSProjectionSurfaceQuad() : base(shaderForMaterial)
            {
            }

            public PQSProjectionSurfaceQuad(string contents) : base(contents)
            {
                base.shader = shaderForMaterial;
            }

            public PQSProjectionSurfaceQuad(Material material) : base(material)
            {
                // Throw exception if this material was not the proper material
                if (material.shader.name != shaderName)
                    throw new InvalidOperationException("PQSProjectionSurfaceQuad material requires the \"" + shaderName + "\" shader");
            }

        }
    }
}
