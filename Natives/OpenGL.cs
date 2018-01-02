using System;

namespace Com.GitHub.ZachDeibert.GraphicsCore {
    public enum GlAccumOp : uint {
        Accum = 0x0100,
        Load = 0x0101,
        Return = 0x0102,
        Mult = 0x0103,
        Add = 0x0104,
    }

    public enum GlAttribMask : uint {
        AccumBufferBit = 0x00000200,
        AllAttribBits = 0xFFFFFFFF,
        ColorBufferBit = 0x00004000,
        CurrentBit = 0x00000001,
        DepthBufferBit = 0x00000100,
        EnableBit = 0x00002000,
        EvalBit = 0x00010000,
        FogBit = 0x00000080,
        HintBit = 0x00008000,
        LightingBit = 0x00000040,
        LineBit = 0x00000004,
        ListBit = 0x00020000,
        MultisampleBit = 0x20000000,
        MultisampleBit3dfx = 0x20000000,
        MultisampleBitArb = 0x20000000,
        MultisampleBitExt = 0x20000000,
        PixelModeBit = 0x00000020,
        PointBit = 0x00000002,
        PolygonBit = 0x00000008,
        PolygonStippleBit = 0x00000010,
        ScissorBit = 0x00080000,
        StencilBufferBit = 0x00000400,
        TextureBit = 0x00040000,
        TransformBit = 0x00001000,
        ViewportBit = 0x00000800,
    }

    public enum GlAlphaFunction : uint {
        Always = 0x0207,
        Equal = 0x0202,
        Gequal = 0x0206,
        Greater = 0x0204,
        Lequal = 0x0203,
        Less = 0x0201,
        Never = 0x0200,
        Notequal = 0x0205,
    }

    public enum GlBlendEquationModeEXT : uint {
        AlphaMaxSgix = 0x8321,
        AlphaMinSgix = 0x8320,
        FuncAddExt = 0x8006,
        FuncReverseSubtractExt = 0x800B,
        FuncSubtractExt = 0x800A,
        LogicOp = 0x0BF1,
        MaxExt = 0x8008,
        MinExt = 0x8007,
        FuncAdd = 0x8006,
        FuncReverseSubtract = 0x800B,
        FuncSubtract = 0x800A,
    }

    public enum GlBoolean : uint {
        False = 0,
        True = 1,
    }

    public enum GlBufferBitQCOM : uint {
        MultisampleBufferBit7Qcom = 0x80000000,
        MultisampleBufferBit6Qcom = 0x40000000,
        MultisampleBufferBit5Qcom = 0x20000000,
        MultisampleBufferBit4Qcom = 0x10000000,
        MultisampleBufferBit3Qcom = 0x08000000,
        MultisampleBufferBit2Qcom = 0x04000000,
        MultisampleBufferBit1Qcom = 0x02000000,
        MultisampleBufferBit0Qcom = 0x01000000,
        StencilBufferBit7Qcom = 0x00800000,
        StencilBufferBit6Qcom = 0x00400000,
        StencilBufferBit5Qcom = 0x00200000,
        StencilBufferBit4Qcom = 0x00100000,
        StencilBufferBit3Qcom = 0x00080000,
        StencilBufferBit2Qcom = 0x00040000,
        StencilBufferBit1Qcom = 0x00020000,
        StencilBufferBit0Qcom = 0x00010000,
        DepthBufferBit7Qcom = 0x00008000,
        DepthBufferBit6Qcom = 0x00004000,
        DepthBufferBit5Qcom = 0x00002000,
        DepthBufferBit4Qcom = 0x00001000,
        DepthBufferBit3Qcom = 0x00000800,
        DepthBufferBit2Qcom = 0x00000400,
        DepthBufferBit1Qcom = 0x00000200,
        DepthBufferBit0Qcom = 0x00000100,
        ColorBufferBit7Qcom = 0x00000080,
        ColorBufferBit6Qcom = 0x00000040,
        ColorBufferBit5Qcom = 0x00000020,
        ColorBufferBit4Qcom = 0x00000010,
        ColorBufferBit3Qcom = 0x00000008,
        ColorBufferBit2Qcom = 0x00000004,
        ColorBufferBit1Qcom = 0x00000002,
        ColorBufferBit0Qcom = 0x00000001,
    }

    public enum GlBufferTargetARB : uint {
        ArrayBuffer = 0x8892,
        AtomicCounterBuffer = 0x92C0,
        CopyReadBuffer = 0x8F36,
        CopyWriteBuffer = 0x8F37,
        DispatchIndirectBuffer = 0x90EE,
        DrawIndirectBuffer = 0x8F3F,
        ElementArrayBuffer = 0x8893,
        PixelPackBuffer = 0x88EB,
        PixelUnpackBuffer = 0x88EC,
        QueryBuffer = 0x9192,
        ShaderStorageBuffer = 0x90D2,
        TextureBuffer = 0x8C2A,
        TransformFeedbackBuffer = 0x8C8E,
        UniformBuffer = 0x8A11,
    }

    public enum GlBufferUsageARB : uint {
        StreamDraw = 0x88E0,
        StreamRead = 0x88E1,
        StreamCopy = 0x88E2,
        StaticDraw = 0x88E4,
        StaticRead = 0x88E5,
        StaticCopy = 0x88E6,
        DynamicDraw = 0x88E8,
        DynamicRead = 0x88E9,
        DynamicCopy = 0x88EA,
    }

    public enum GlBufferAccessARB : uint {
        ReadOnly = 0x88B8,
        WriteOnly = 0x88B9,
        ReadWrite = 0x88BA,
    }

    public enum GlBufferAccessMask : uint {
        MapCoherentBit = 0x0080,
        MapCoherentBitExt = 0x0080,
        MapFlushExplicitBit = 0x0010,
        MapFlushExplicitBitExt = 0x0010,
        MapInvalidateBufferBit = 0x0008,
        MapInvalidateBufferBitExt = 0x0008,
        MapInvalidateRangeBit = 0x0004,
        MapInvalidateRangeBitExt = 0x0004,
        MapPersistentBit = 0x0040,
        MapPersistentBitExt = 0x0040,
        MapReadBit = 0x0001,
        MapReadBitExt = 0x0001,
        MapUnsynchronizedBit = 0x0020,
        MapUnsynchronizedBitExt = 0x0020,
        MapWriteBit = 0x0002,
        MapWriteBitExt = 0x0002,
    }

    public enum GlClearBufferMask : uint {
        AccumBufferBit = 0x00000200,
        ColorBufferBit = 0x00004000,
        CoverageBufferBitNv = 0x00008000,
        DepthBufferBit = 0x00000100,
        StencilBufferBit = 0x00000400,
    }

    public enum GlClientAttribMask : uint {
        ClientAllAttribBits = 0xFFFFFFFF,
        ClientPixelStoreBit = 0x00000001,
        ClientVertexArrayBit = 0x00000002,
    }

    public enum GlClipPlaneName : uint {
        ClipDistance0 = 0x3000,
        ClipDistance1 = 0x3001,
        ClipDistance2 = 0x3002,
        ClipDistance3 = 0x3003,
        ClipDistance4 = 0x3004,
        ClipDistance5 = 0x3005,
        ClipDistance6 = 0x3006,
        ClipDistance7 = 0x3007,
        ClipPlane0 = 0x3000,
        ClipPlane1 = 0x3001,
        ClipPlane2 = 0x3002,
        ClipPlane3 = 0x3003,
        ClipPlane4 = 0x3004,
        ClipPlane5 = 0x3005,
    }

    public enum GlColorMaterialFace : uint {
        Back = 0x0405,
        Front = 0x0404,
        FrontAndBack = 0x0408,
    }

    public enum GlColorMaterialParameter : uint {
        Ambient = 0x1200,
        AmbientAndDiffuse = 0x1602,
        Diffuse = 0x1201,
        Emission = 0x1600,
        Specular = 0x1202,
    }

    public enum GlColorPointerType : uint {
        Byte = 0x1400,
        Double = 0x140A,
        Float = 0x1406,
        Int = 0x1404,
        Short = 0x1402,
        UnsignedByte = 0x1401,
        UnsignedInt = 0x1405,
        UnsignedShort = 0x1403,
    }

    public enum GlColorTableParameterPNameSGI : uint {
        ColorTableBias = 0x80D7,
        ColorTableBiasSgi = 0x80D7,
        ColorTableScale = 0x80D6,
        ColorTableScaleSgi = 0x80D6,
    }

    public enum GlColorTableTargetSGI : uint {
        ColorTable = 0x80D0,
        ColorTableSgi = 0x80D0,
        PostColorMatrixColorTable = 0x80D2,
        PostColorMatrixColorTableSgi = 0x80D2,
        PostConvolutionColorTable = 0x80D1,
        PostConvolutionColorTableSgi = 0x80D1,
        ProxyColorTable = 0x80D3,
        ProxyColorTableSgi = 0x80D3,
        ProxyPostColorMatrixColorTable = 0x80D5,
        ProxyPostColorMatrixColorTableSgi = 0x80D5,
        ProxyPostConvolutionColorTable = 0x80D4,
        ProxyPostConvolutionColorTableSgi = 0x80D4,
        ProxyTextureColorTableSgi = 0x80BD,
        TextureColorTableSgi = 0x80BC,
    }

    public enum GlContextFlagMask : uint {
        ContextFlagDebugBit = 0x00000002,
        ContextFlagDebugBitKhr = 0x00000002,
        ContextFlagForwardCompatibleBit = 0x00000001,
        ContextFlagRobustAccessBit = 0x00000004,
        ContextFlagRobustAccessBitArb = 0x00000004,
        ContextFlagProtectedContentBitExt = 0x00000010,
        ContextFlagNoErrorBit = 0x00000008,
        ContextFlagNoErrorBitKhr = 0x00000008,
    }

    public enum GlContextProfileMask : uint {
        ContextCompatibilityProfileBit = 0x00000002,
        ContextCoreProfileBit = 0x00000001,
    }

    public enum GlConvolutionBorderModeEXT : uint {
        Reduce = 0x8016,
        ReduceExt = 0x8016,
    }

    public enum GlConvolutionParameterEXT : uint {
        ConvolutionBorderMode = 0x8013,
        ConvolutionBorderModeExt = 0x8013,
        ConvolutionFilterBias = 0x8015,
        ConvolutionFilterBiasExt = 0x8015,
        ConvolutionFilterScale = 0x8014,
        ConvolutionFilterScaleExt = 0x8014,
    }

    public enum GlConvolutionTargetEXT : uint {
        Convolution1d = 0x8010,
        Convolution1dExt = 0x8010,
        Convolution2d = 0x8011,
        Convolution2dExt = 0x8011,
    }

    public enum GlCullFaceMode : uint {
        Back = 0x0405,
        Front = 0x0404,
        FrontAndBack = 0x0408,
    }

    public enum GlDataType : uint {
    }

    public enum GlDepthFunction : uint {
        Always = 0x0207,
        Equal = 0x0202,
        Gequal = 0x0206,
        Greater = 0x0204,
        Lequal = 0x0203,
        Less = 0x0201,
        Never = 0x0200,
        Notequal = 0x0205,
    }

    public enum GlDrawBufferMode : uint {
        Aux0 = 0x0409,
        Aux1 = 0x040A,
        Aux2 = 0x040B,
        Aux3 = 0x040C,
        Back = 0x0405,
        BackLeft = 0x0402,
        BackRight = 0x0403,
        Front = 0x0404,
        FrontAndBack = 0x0408,
        FrontLeft = 0x0400,
        FrontRight = 0x0401,
        Left = 0x0406,
        None = 0,
        NoneOes = 0,
        Right = 0x0407,
    }

    public enum GlDrawElementsType : uint {
        UnsignedByte = 0x1401,
        UnsignedShort = 0x1403,
        UnsignedInt = 0x1405,
    }

    public enum GlEnableCap : uint {
        AlphaTest = 0x0BC0,
        AsyncDrawPixelsSgix = 0x835D,
        AsyncHistogramSgix = 0x832C,
        AsyncReadPixelsSgix = 0x835E,
        AsyncTexImageSgix = 0x835C,
        AutoNormal = 0x0D80,
        Blend = 0x0BE2,
        CalligraphicFragmentSgix = 0x8183,
        ClipPlane0 = 0x3000,
        ClipPlane1 = 0x3001,
        ClipPlane2 = 0x3002,
        ClipPlane3 = 0x3003,
        ClipPlane4 = 0x3004,
        ClipPlane5 = 0x3005,
        ColorArray = 0x8076,
        ColorLogicOp = 0x0BF2,
        ColorMaterial = 0x0B57,
        ColorTableSgi = 0x80D0,
        Convolution1dExt = 0x8010,
        Convolution2dExt = 0x8011,
        CullFace = 0x0B44,
        DepthTest = 0x0B71,
        Dither = 0x0BD0,
        EdgeFlagArray = 0x8079,
        Fog = 0x0B60,
        FogOffsetSgix = 0x8198,
        FragmentColorMaterialSgix = 0x8401,
        FragmentLight0Sgix = 0x840C,
        FragmentLight1Sgix = 0x840D,
        FragmentLight2Sgix = 0x840E,
        FragmentLight3Sgix = 0x840F,
        FragmentLight4Sgix = 0x8410,
        FragmentLight5Sgix = 0x8411,
        FragmentLight6Sgix = 0x8412,
        FragmentLight7Sgix = 0x8413,
        FragmentLightingSgix = 0x8400,
        FramezoomSgix = 0x818B,
        HistogramExt = 0x8024,
        IndexArray = 0x8077,
        IndexLogicOp = 0x0BF1,
        InterlaceSgix = 0x8094,
        IrInstrument1Sgix = 0x817F,
        Light0 = 0x4000,
        Light1 = 0x4001,
        Light2 = 0x4002,
        Light3 = 0x4003,
        Light4 = 0x4004,
        Light5 = 0x4005,
        Light6 = 0x4006,
        Light7 = 0x4007,
        Lighting = 0x0B50,
        LineSmooth = 0x0B20,
        LineStipple = 0x0B24,
        Map1Color4 = 0x0D90,
        Map1Index = 0x0D91,
        Map1Normal = 0x0D92,
        Map1TextureCoord1 = 0x0D93,
        Map1TextureCoord2 = 0x0D94,
        Map1TextureCoord3 = 0x0D95,
        Map1TextureCoord4 = 0x0D96,
        Map1Vertex3 = 0x0D97,
        Map1Vertex4 = 0x0D98,
        Map2Color4 = 0x0DB0,
        Map2Index = 0x0DB1,
        Map2Normal = 0x0DB2,
        Map2TextureCoord1 = 0x0DB3,
        Map2TextureCoord2 = 0x0DB4,
        Map2TextureCoord3 = 0x0DB5,
        Map2TextureCoord4 = 0x0DB6,
        Map2Vertex3 = 0x0DB7,
        Map2Vertex4 = 0x0DB8,
        MinmaxExt = 0x802E,
        MultisampleSgis = 0x809D,
        Normalize = 0x0BA1,
        NormalArray = 0x8075,
        PixelTextureSgis = 0x8353,
        PixelTexGenSgix = 0x8139,
        PointSmooth = 0x0B10,
        PolygonOffsetFill = 0x8037,
        PolygonOffsetLine = 0x2A02,
        PolygonOffsetPoint = 0x2A01,
        PolygonSmooth = 0x0B41,
        PolygonStipple = 0x0B42,
        PostColorMatrixColorTableSgi = 0x80D2,
        PostConvolutionColorTableSgi = 0x80D1,
        ReferencePlaneSgix = 0x817D,
        RescaleNormalExt = 0x803A,
        SampleAlphaToMaskSgis = 0x809E,
        SampleAlphaToOneSgis = 0x809F,
        SampleMaskSgis = 0x80A0,
        ScissorTest = 0x0C11,
        Separable2dExt = 0x8012,
        SharedTexturePaletteExt = 0x81FB,
        SpriteSgix = 0x8148,
        StencilTest = 0x0B90,
        Texture1d = 0x0DE0,
        Texture2d = 0x0DE1,
        Texture3dExt = 0x806F,
        Texture4dSgis = 0x8134,
        TextureColorTableSgi = 0x80BC,
        TextureCoordArray = 0x8078,
        TextureGenQ = 0x0C63,
        TextureGenR = 0x0C62,
        TextureGenS = 0x0C60,
        TextureGenT = 0x0C61,
        VertexArray = 0x8074,
    }

    public enum GlErrorCode : uint {
        InvalidEnum = 0x0500,
        InvalidFramebufferOperation = 0x0506,
        InvalidFramebufferOperationExt = 0x0506,
        InvalidFramebufferOperationOes = 0x0506,
        InvalidOperation = 0x0502,
        InvalidValue = 0x0501,
        NoError = 0,
        OutOfMemory = 0x0505,
        StackOverflow = 0x0503,
        StackUnderflow = 0x0504,
        TableTooLarge = 0x8031,
        TableTooLargeExt = 0x8031,
        TextureTooLargeExt = 0x8065,
    }

    public enum GlExternalHandleType : uint {
        HandleTypeOpaqueFdExt = 0x9586,
        HandleTypeOpaqueWin32Ext = 0x9587,
        HandleTypeOpaqueWin32KmtExt = 0x9588,
        HandleTypeD3d12TilepoolExt = 0x9589,
        HandleTypeD3d12ResourceExt = 0x958A,
        HandleTypeD3d11ImageExt = 0x958B,
        HandleTypeD3d11ImageKmtExt = 0x958C,
        HandleTypeD3d12FenceExt = 0x9594,
    }

    public enum GlFeedbackType : uint {
        Gl2d = 0x0600,
        Gl3d = 0x0601,
        Gl3dColor = 0x0602,
        Gl3dColorTexture = 0x0603,
        Gl4dColorTexture = 0x0604,
    }

    public enum GlFeedBackToken : uint {
        BitmapToken = 0x0704,
        CopyPixelToken = 0x0706,
        DrawPixelToken = 0x0705,
        LineResetToken = 0x0707,
        LineToken = 0x0702,
        PassThroughToken = 0x0700,
        PointToken = 0x0701,
        PolygonToken = 0x0703,
    }

    public enum GlFfdMaskSGIX : uint {
    }

    public enum GlFfdTargetSGIX : uint {
        GeometryDeformationSgix = 0x8194,
        TextureDeformationSgix = 0x8195,
    }

    public enum GlFogCoordinatePointerType : uint {
        Float = 0x1406,
        Double = 0x140A,
    }

    public enum GlFogMode : uint {
        Exp = 0x0800,
        Exp2 = 0x0801,
        FogFuncSgis = 0x812A,
        Linear = 0x2601,
    }

    public enum GlFogParameter : uint {
        FogColor = 0x0B66,
        FogDensity = 0x0B62,
        FogEnd = 0x0B64,
        FogIndex = 0x0B61,
        FogMode = 0x0B65,
        FogOffsetValueSgix = 0x8199,
        FogStart = 0x0B63,
    }

    public enum GlFogPointerTypeEXT : uint {
        Float = 0x1406,
        Double = 0x140A,
    }

    public enum GlFogPointerTypeIBM : uint {
        Float = 0x1406,
        Double = 0x140A,
    }

    public enum GlFragmentLightModelParameterSGIX : uint {
        FragmentLightModelAmbientSgix = 0x840A,
        FragmentLightModelLocalViewerSgix = 0x8408,
        FragmentLightModelNormalInterpolationSgix = 0x840B,
        FragmentLightModelTwoSideSgix = 0x8409,
    }

    public enum GlFramebufferFetchNoncoherent : uint {
        FramebufferFetchNoncoherentQcom = 0x96A2,
    }

    public enum GlFrontFaceDirection : uint {
        Ccw = 0x0901,
        Cw = 0x0900,
    }

    public enum GlGetColorTableParameterPNameSGI : uint {
        ColorTableAlphaSizeSgi = 0x80DD,
        ColorTableBiasSgi = 0x80D7,
        ColorTableBlueSizeSgi = 0x80DC,
        ColorTableFormatSgi = 0x80D8,
        ColorTableGreenSizeSgi = 0x80DB,
        ColorTableIntensitySizeSgi = 0x80DF,
        ColorTableLuminanceSizeSgi = 0x80DE,
        ColorTableRedSizeSgi = 0x80DA,
        ColorTableScaleSgi = 0x80D6,
        ColorTableWidthSgi = 0x80D9,
        ColorTableBias = 0x80D7,
        ColorTableScale = 0x80D6,
        ColorTableFormat = 0x80D8,
        ColorTableWidth = 0x80D9,
        ColorTableRedSize = 0x80DA,
        ColorTableGreenSize = 0x80DB,
        ColorTableBlueSize = 0x80DC,
        ColorTableAlphaSize = 0x80DD,
        ColorTableLuminanceSize = 0x80DE,
        ColorTableIntensitySize = 0x80DF,
    }

    public enum GlGetConvolutionParameter : uint {
        ConvolutionBorderModeExt = 0x8013,
        ConvolutionFilterBiasExt = 0x8015,
        ConvolutionFilterScaleExt = 0x8014,
        ConvolutionFormatExt = 0x8017,
        ConvolutionHeightExt = 0x8019,
        ConvolutionWidthExt = 0x8018,
        MaxConvolutionHeightExt = 0x801B,
        MaxConvolutionWidthExt = 0x801A,
        ConvolutionBorderMode = 0x8013,
        ConvolutionBorderColor = 0x8154,
        ConvolutionFilterScale = 0x8014,
        ConvolutionFilterBias = 0x8015,
        ConvolutionFormat = 0x8017,
        ConvolutionWidth = 0x8018,
        ConvolutionHeight = 0x8019,
        MaxConvolutionWidth = 0x801A,
        MaxConvolutionHeight = 0x801B,
    }

    public enum GlGetHistogramParameterPNameEXT : uint {
        HistogramAlphaSizeExt = 0x802B,
        HistogramBlueSizeExt = 0x802A,
        HistogramFormatExt = 0x8027,
        HistogramGreenSizeExt = 0x8029,
        HistogramLuminanceSizeExt = 0x802C,
        HistogramRedSizeExt = 0x8028,
        HistogramSinkExt = 0x802D,
        HistogramWidthExt = 0x8026,
        HistogramWidth = 0x8026,
        HistogramFormat = 0x8027,
        HistogramRedSize = 0x8028,
        HistogramGreenSize = 0x8029,
        HistogramBlueSize = 0x802A,
        HistogramAlphaSize = 0x802B,
        HistogramLuminanceSize = 0x802C,
        HistogramSink = 0x802D,
    }

    public enum GlGetMapQuery : uint {
        Coeff = 0x0A00,
        Domain = 0x0A02,
        Order = 0x0A01,
    }

    public enum GlGetMinmaxParameterPNameEXT : uint {
        MinmaxFormat = 0x802F,
        MinmaxFormatExt = 0x802F,
        MinmaxSink = 0x8030,
        MinmaxSinkExt = 0x8030,
    }

    public enum GlGetPixelMap : uint {
        PixelMapAToA = 0x0C79,
        PixelMapBToB = 0x0C78,
        PixelMapGToG = 0x0C77,
        PixelMapIToA = 0x0C75,
        PixelMapIToB = 0x0C74,
        PixelMapIToG = 0x0C73,
        PixelMapIToI = 0x0C70,
        PixelMapIToR = 0x0C72,
        PixelMapRToR = 0x0C76,
        PixelMapSToS = 0x0C71,
    }

    public enum GlGetPName : uint {
        AccumAlphaBits = 0x0D5B,
        AccumBlueBits = 0x0D5A,
        AccumClearValue = 0x0B80,
        AccumGreenBits = 0x0D59,
        AccumRedBits = 0x0D58,
        AliasedLineWidthRange = 0x846E,
        AliasedPointSizeRange = 0x846D,
        AlphaBias = 0x0D1D,
        AlphaBits = 0x0D55,
        AlphaScale = 0x0D1C,
        AlphaTest = 0x0BC0,
        AlphaTestFunc = 0x0BC1,
        AlphaTestFuncQcom = 0x0BC1,
        AlphaTestQcom = 0x0BC0,
        AlphaTestRef = 0x0BC2,
        AlphaTestRefQcom = 0x0BC2,
        AsyncDrawPixelsSgix = 0x835D,
        AsyncHistogramSgix = 0x832C,
        AsyncMarkerSgix = 0x8329,
        AsyncReadPixelsSgix = 0x835E,
        AsyncTexImageSgix = 0x835C,
        AttribStackDepth = 0x0BB0,
        AutoNormal = 0x0D80,
        AuxBuffers = 0x0C00,
        Blend = 0x0BE2,
        BlendColorExt = 0x8005,
        BlendDst = 0x0BE0,
        BlendEquationExt = 0x8009,
        BlendSrc = 0x0BE1,
        BlueBias = 0x0D1B,
        BlueBits = 0x0D54,
        BlueScale = 0x0D1A,
        CalligraphicFragmentSgix = 0x8183,
        ClientAttribStackDepth = 0x0BB1,
        ClipPlane0 = 0x3000,
        ClipPlane1 = 0x3001,
        ClipPlane2 = 0x3002,
        ClipPlane3 = 0x3003,
        ClipPlane4 = 0x3004,
        ClipPlane5 = 0x3005,
        ColorArray = 0x8076,
        ColorArrayCountExt = 0x8084,
        ColorArraySize = 0x8081,
        ColorArrayStride = 0x8083,
        ColorArrayType = 0x8082,
        ColorClearValue = 0x0C22,
        ColorLogicOp = 0x0BF2,
        ColorMaterial = 0x0B57,
        ColorMaterialFace = 0x0B55,
        ColorMaterialParameter = 0x0B56,
        ColorMatrixSgi = 0x80B1,
        ColorMatrixStackDepthSgi = 0x80B2,
        ColorTableSgi = 0x80D0,
        ColorWritemask = 0x0C23,
        Convolution1dExt = 0x8010,
        Convolution2dExt = 0x8011,
        ConvolutionHintSgix = 0x8316,
        CullFace = 0x0B44,
        CullFaceMode = 0x0B45,
        CurrentColor = 0x0B00,
        CurrentIndex = 0x0B01,
        CurrentNormal = 0x0B02,
        CurrentRasterColor = 0x0B04,
        CurrentRasterDistance = 0x0B09,
        CurrentRasterIndex = 0x0B05,
        CurrentRasterPosition = 0x0B07,
        CurrentRasterPositionValid = 0x0B08,
        CurrentRasterTextureCoords = 0x0B06,
        CurrentTextureCoords = 0x0B03,
        DeformationsMaskSgix = 0x8196,
        DepthBias = 0x0D1F,
        DepthBits = 0x0D56,
        DepthClearValue = 0x0B73,
        DepthFunc = 0x0B74,
        DepthRange = 0x0B70,
        DepthScale = 0x0D1E,
        DepthTest = 0x0B71,
        DepthWritemask = 0x0B72,
        DetailTexture2dBindingSgis = 0x8096,
        DeviceLuidExt = 0x9599,
        DeviceNodeMaskExt = 0x959A,
        DeviceUuidExt = 0x9597,
        DistanceAttenuationSgis = 0x8129,
        Dither = 0x0BD0,
        Doublebuffer = 0x0C32,
        DrawBuffer = 0x0C01,
        DrawBufferExt = 0x0C01,
        DriverUuidExt = 0x9598,
        EdgeFlag = 0x0B43,
        EdgeFlagArray = 0x8079,
        EdgeFlagArrayCountExt = 0x808D,
        EdgeFlagArrayStride = 0x808C,
        FeedbackBufferSize = 0x0DF1,
        FeedbackBufferType = 0x0DF2,
        Fog = 0x0B60,
        FogColor = 0x0B66,
        FogDensity = 0x0B62,
        FogEnd = 0x0B64,
        FogFuncPointsSgis = 0x812B,
        FogHint = 0x0C54,
        FogIndex = 0x0B61,
        FogMode = 0x0B65,
        FogOffsetSgix = 0x8198,
        FogOffsetValueSgix = 0x8199,
        FogStart = 0x0B63,
        FragmentColorMaterialFaceSgix = 0x8402,
        FragmentColorMaterialParameterSgix = 0x8403,
        FragmentColorMaterialSgix = 0x8401,
        FragmentLight0Sgix = 0x840C,
        FragmentLightingSgix = 0x8400,
        FragmentLightModelAmbientSgix = 0x840A,
        FragmentLightModelLocalViewerSgix = 0x8408,
        FragmentLightModelNormalInterpolationSgix = 0x840B,
        FragmentLightModelTwoSideSgix = 0x8409,
        FramezoomFactorSgix = 0x818C,
        FramezoomSgix = 0x818B,
        FrontFace = 0x0B46,
        GenerateMipmapHintSgis = 0x8192,
        GreenBias = 0x0D19,
        GreenBits = 0x0D53,
        GreenScale = 0x0D18,
        HistogramExt = 0x8024,
        IndexArray = 0x8077,
        IndexArrayCountExt = 0x8087,
        IndexArrayStride = 0x8086,
        IndexArrayType = 0x8085,
        IndexBits = 0x0D51,
        IndexClearValue = 0x0C20,
        IndexLogicOp = 0x0BF1,
        IndexMode = 0x0C30,
        IndexOffset = 0x0D13,
        IndexShift = 0x0D12,
        IndexWritemask = 0x0C21,
        InstrumentMeasurementsSgix = 0x8181,
        InterlaceSgix = 0x8094,
        IrInstrument1Sgix = 0x817F,
        Light0 = 0x4000,
        Light1 = 0x4001,
        Light2 = 0x4002,
        Light3 = 0x4003,
        Light4 = 0x4004,
        Light5 = 0x4005,
        Light6 = 0x4006,
        Light7 = 0x4007,
        Lighting = 0x0B50,
        LightEnvModeSgix = 0x8407,
        LightModelAmbient = 0x0B53,
        LightModelColorControl = 0x81F8,
        LightModelLocalViewer = 0x0B51,
        LightModelTwoSide = 0x0B52,
        LineSmooth = 0x0B20,
        LineSmoothHint = 0x0C52,
        LineStipple = 0x0B24,
        LineStipplePattern = 0x0B25,
        LineStippleRepeat = 0x0B26,
        LineWidth = 0x0B21,
        LineWidthGranularity = 0x0B23,
        LineWidthRange = 0x0B22,
        ListBase = 0x0B32,
        ListIndex = 0x0B33,
        ListMode = 0x0B30,
        LogicOp = 0x0BF1,
        LogicOpMode = 0x0BF0,
        Map1Color4 = 0x0D90,
        Map1GridDomain = 0x0DD0,
        Map1GridSegments = 0x0DD1,
        Map1Index = 0x0D91,
        Map1Normal = 0x0D92,
        Map1TextureCoord1 = 0x0D93,
        Map1TextureCoord2 = 0x0D94,
        Map1TextureCoord3 = 0x0D95,
        Map1TextureCoord4 = 0x0D96,
        Map1Vertex3 = 0x0D97,
        Map1Vertex4 = 0x0D98,
        Map2Color4 = 0x0DB0,
        Map2GridDomain = 0x0DD2,
        Map2GridSegments = 0x0DD3,
        Map2Index = 0x0DB1,
        Map2Normal = 0x0DB2,
        Map2TextureCoord1 = 0x0DB3,
        Map2TextureCoord2 = 0x0DB4,
        Map2TextureCoord3 = 0x0DB5,
        Map2TextureCoord4 = 0x0DB6,
        Map2Vertex3 = 0x0DB7,
        Map2Vertex4 = 0x0DB8,
        MapColor = 0x0D10,
        MapStencil = 0x0D11,
        MatrixMode = 0x0BA0,
        Max3dTextureSizeExt = 0x8073,
        Max4dTextureSizeSgis = 0x8138,
        MaxActiveLightsSgix = 0x8405,
        MaxAsyncDrawPixelsSgix = 0x8360,
        MaxAsyncHistogramSgix = 0x832D,
        MaxAsyncReadPixelsSgix = 0x8361,
        MaxAsyncTexImageSgix = 0x835F,
        MaxAttribStackDepth = 0x0D35,
        MaxClientAttribStackDepth = 0x0D3B,
        MaxClipmapDepthSgix = 0x8177,
        MaxClipmapVirtualDepthSgix = 0x8178,
        MaxClipDistances = 0x0D32,
        MaxClipPlanes = 0x0D32,
        MaxColorMatrixStackDepthSgi = 0x80B3,
        MaxEvalOrder = 0x0D30,
        MaxFogFuncPointsSgis = 0x812C,
        MaxFragmentLightsSgix = 0x8404,
        MaxFramezoomFactorSgix = 0x818D,
        MaxLights = 0x0D31,
        MaxListNesting = 0x0B31,
        MaxModelviewStackDepth = 0x0D36,
        MaxNameStackDepth = 0x0D37,
        MaxPixelMapTable = 0x0D34,
        MaxProjectionStackDepth = 0x0D38,
        MaxTextureSize = 0x0D33,
        MaxTextureStackDepth = 0x0D39,
        MaxViewportDims = 0x0D3A,
        MinmaxExt = 0x802E,
        Modelview0MatrixExt = 0x0BA6,
        Modelview0StackDepthExt = 0x0BA3,
        ModelviewMatrix = 0x0BA6,
        ModelviewStackDepth = 0x0BA3,
        MultisampleSgis = 0x809D,
        NameStackDepth = 0x0D70,
        Normalize = 0x0BA1,
        NormalArray = 0x8075,
        NormalArrayCountExt = 0x8080,
        NormalArrayStride = 0x807F,
        NormalArrayType = 0x807E,
        PackAlignment = 0x0D05,
        PackCmykHintExt = 0x800E,
        PackImageDepthSgis = 0x8131,
        PackImageHeightExt = 0x806C,
        PackLsbFirst = 0x0D01,
        PackResampleSgix = 0x842E,
        PackRowLength = 0x0D02,
        PackSkipImagesExt = 0x806B,
        PackSkipPixels = 0x0D04,
        PackSkipRows = 0x0D03,
        PackSkipVolumesSgis = 0x8130,
        PackSubsampleRateSgix = 0x85A0,
        PackSwapBytes = 0x0D00,
        PerspectiveCorrectionHint = 0x0C50,
        PixelMapAToASize = 0x0CB9,
        PixelMapBToBSize = 0x0CB8,
        PixelMapGToGSize = 0x0CB7,
        PixelMapIToASize = 0x0CB5,
        PixelMapIToBSize = 0x0CB4,
        PixelMapIToGSize = 0x0CB3,
        PixelMapIToISize = 0x0CB0,
        PixelMapIToRSize = 0x0CB2,
        PixelMapRToRSize = 0x0CB6,
        PixelMapSToSSize = 0x0CB1,
        PixelTextureSgis = 0x8353,
        PixelTexGenModeSgix = 0x832B,
        PixelTexGenSgix = 0x8139,
        PixelTileBestAlignmentSgix = 0x813E,
        PixelTileCacheIncrementSgix = 0x813F,
        PixelTileCacheSizeSgix = 0x8145,
        PixelTileGridDepthSgix = 0x8144,
        PixelTileGridHeightSgix = 0x8143,
        PixelTileGridWidthSgix = 0x8142,
        PixelTileHeightSgix = 0x8141,
        PixelTileWidthSgix = 0x8140,
        PointFadeThresholdSizeSgis = 0x8128,
        PointSize = 0x0B11,
        PointSizeGranularity = 0x0B13,
        PointSizeMaxSgis = 0x8127,
        PointSizeMinSgis = 0x8126,
        PointSizeRange = 0x0B12,
        PointSmooth = 0x0B10,
        PointSmoothHint = 0x0C51,
        PolygonMode = 0x0B40,
        PolygonOffsetBiasExt = 0x8039,
        PolygonOffsetFactor = 0x8038,
        PolygonOffsetFill = 0x8037,
        PolygonOffsetLine = 0x2A02,
        PolygonOffsetPoint = 0x2A01,
        PolygonOffsetUnits = 0x2A00,
        PolygonSmooth = 0x0B41,
        PolygonSmoothHint = 0x0C53,
        PolygonStipple = 0x0B42,
        PostColorMatrixAlphaBiasSgi = 0x80BB,
        PostColorMatrixAlphaScaleSgi = 0x80B7,
        PostColorMatrixBlueBiasSgi = 0x80BA,
        PostColorMatrixBlueScaleSgi = 0x80B6,
        PostColorMatrixColorTableSgi = 0x80D2,
        PostColorMatrixGreenBiasSgi = 0x80B9,
        PostColorMatrixGreenScaleSgi = 0x80B5,
        PostColorMatrixRedBiasSgi = 0x80B8,
        PostColorMatrixRedScaleSgi = 0x80B4,
        PostConvolutionAlphaBiasExt = 0x8023,
        PostConvolutionAlphaScaleExt = 0x801F,
        PostConvolutionBlueBiasExt = 0x8022,
        PostConvolutionBlueScaleExt = 0x801E,
        PostConvolutionColorTableSgi = 0x80D1,
        PostConvolutionGreenBiasExt = 0x8021,
        PostConvolutionGreenScaleExt = 0x801D,
        PostConvolutionRedBiasExt = 0x8020,
        PostConvolutionRedScaleExt = 0x801C,
        PostTextureFilterBiasRangeSgix = 0x817B,
        PostTextureFilterScaleRangeSgix = 0x817C,
        ProjectionMatrix = 0x0BA7,
        ProjectionStackDepth = 0x0BA4,
        ReadBuffer = 0x0C02,
        ReadBufferExt = 0x0C02,
        ReadBufferNv = 0x0C02,
        RedBias = 0x0D15,
        RedBits = 0x0D52,
        RedScale = 0x0D14,
        ReferencePlaneEquationSgix = 0x817E,
        ReferencePlaneSgix = 0x817D,
        RenderMode = 0x0C40,
        RescaleNormalExt = 0x803A,
        RgbaMode = 0x0C31,
        SamplesSgis = 0x80A9,
        SampleAlphaToMaskSgis = 0x809E,
        SampleAlphaToOneSgis = 0x809F,
        SampleBuffersSgis = 0x80A8,
        SampleMaskInvertSgis = 0x80AB,
        SampleMaskSgis = 0x80A0,
        SampleMaskValueSgis = 0x80AA,
        SamplePatternSgis = 0x80AC,
        ScissorBox = 0x0C10,
        ScissorTest = 0x0C11,
        SelectionBufferSize = 0x0DF4,
        Separable2dExt = 0x8012,
        ShadeModel = 0x0B54,
        SharedTexturePaletteExt = 0x81FB,
        SmoothLineWidthGranularity = 0x0B23,
        SmoothLineWidthRange = 0x0B22,
        SmoothPointSizeGranularity = 0x0B13,
        SmoothPointSizeRange = 0x0B12,
        SpriteAxisSgix = 0x814A,
        SpriteModeSgix = 0x8149,
        SpriteSgix = 0x8148,
        SpriteTranslationSgix = 0x814B,
        StencilBits = 0x0D57,
        StencilClearValue = 0x0B91,
        StencilFail = 0x0B94,
        StencilFunc = 0x0B92,
        StencilPassDepthFail = 0x0B95,
        StencilPassDepthPass = 0x0B96,
        StencilRef = 0x0B97,
        StencilTest = 0x0B90,
        StencilValueMask = 0x0B93,
        StencilWritemask = 0x0B98,
        Stereo = 0x0C33,
        SubpixelBits = 0x0D50,
        Texture1d = 0x0DE0,
        Texture2d = 0x0DE1,
        Texture3dBindingExt = 0x806A,
        Texture3dExt = 0x806F,
        Texture4dBindingSgis = 0x814F,
        Texture4dSgis = 0x8134,
        TextureBinding1d = 0x8068,
        TextureBinding2d = 0x8069,
        TextureBinding3d = 0x806A,
        TextureColorTableSgi = 0x80BC,
        TextureCoordArray = 0x8078,
        TextureCoordArrayCountExt = 0x808B,
        TextureCoordArraySize = 0x8088,
        TextureCoordArrayStride = 0x808A,
        TextureCoordArrayType = 0x8089,
        TextureGenQ = 0x0C63,
        TextureGenR = 0x0C62,
        TextureGenS = 0x0C60,
        TextureGenT = 0x0C61,
        TextureMatrix = 0x0BA8,
        TextureStackDepth = 0x0BA5,
        UnpackAlignment = 0x0CF5,
        UnpackCmykHintExt = 0x800F,
        UnpackImageDepthSgis = 0x8133,
        UnpackImageHeightExt = 0x806E,
        UnpackLsbFirst = 0x0CF1,
        UnpackResampleSgix = 0x842F,
        UnpackRowLength = 0x0CF2,
        UnpackSkipImagesExt = 0x806D,
        UnpackSkipPixels = 0x0CF4,
        UnpackSkipRows = 0x0CF3,
        UnpackSkipVolumesSgis = 0x8132,
        UnpackSubsampleRateSgix = 0x85A1,
        UnpackSwapBytes = 0x0CF0,
        VertexArray = 0x8074,
        VertexArrayCountExt = 0x807D,
        VertexArraySize = 0x807A,
        VertexArrayStride = 0x807C,
        VertexArrayType = 0x807B,
        VertexPreclipHintSgix = 0x83EF,
        VertexPreclipSgix = 0x83EE,
        Viewport = 0x0BA2,
        ZoomX = 0x0D16,
        ZoomY = 0x0D17,
    }

    public enum GlGetPointervPName : uint {
        ColorArrayPointer = 0x8090,
        ColorArrayPointerExt = 0x8090,
        EdgeFlagArrayPointer = 0x8093,
        EdgeFlagArrayPointerExt = 0x8093,
        FeedbackBufferPointer = 0x0DF0,
        IndexArrayPointer = 0x8091,
        IndexArrayPointerExt = 0x8091,
        InstrumentBufferPointerSgix = 0x8180,
        NormalArrayPointer = 0x808F,
        NormalArrayPointerExt = 0x808F,
        SelectionBufferPointer = 0x0DF3,
        TextureCoordArrayPointer = 0x8092,
        TextureCoordArrayPointerExt = 0x8092,
        VertexArrayPointer = 0x808E,
        VertexArrayPointerExt = 0x808E,
        DebugCallbackFunction = 0x8244,
        DebugCallbackUserParam = 0x8245,
    }

    public enum GlGetTextureParameter : uint {
        DetailTextureFuncPointsSgis = 0x809C,
        DetailTextureLevelSgis = 0x809A,
        DetailTextureModeSgis = 0x809B,
        DualTextureSelectSgis = 0x8124,
        GenerateMipmapSgis = 0x8191,
        PostTextureFilterBiasSgix = 0x8179,
        PostTextureFilterScaleSgix = 0x817A,
        QuadTextureSelectSgis = 0x8125,
        ShadowAmbientSgix = 0x80BF,
        SharpenTextureFuncPointsSgis = 0x80B0,
        Texture4dsizeSgis = 0x8136,
        TextureAlphaSize = 0x805F,
        TextureBaseLevelSgis = 0x813C,
        TextureBlueSize = 0x805E,
        TextureBorder = 0x1005,
        TextureBorderColor = 0x1004,
        TextureBorderColorNv = 0x1004,
        TextureClipmapCenterSgix = 0x8171,
        TextureClipmapDepthSgix = 0x8176,
        TextureClipmapFrameSgix = 0x8172,
        TextureClipmapLodOffsetSgix = 0x8175,
        TextureClipmapOffsetSgix = 0x8173,
        TextureClipmapVirtualDepthSgix = 0x8174,
        TextureCompareOperatorSgix = 0x819B,
        TextureCompareSgix = 0x819A,
        TextureComponents = 0x1003,
        TextureDepthExt = 0x8071,
        TextureFilter4SizeSgis = 0x8147,
        TextureGequalRSgix = 0x819D,
        TextureGreenSize = 0x805D,
        TextureHeight = 0x1001,
        TextureIntensitySize = 0x8061,
        TextureInternalFormat = 0x1003,
        TextureLequalRSgix = 0x819C,
        TextureLodBiasRSgix = 0x8190,
        TextureLodBiasSSgix = 0x818E,
        TextureLodBiasTSgix = 0x818F,
        TextureLuminanceSize = 0x8060,
        TextureMagFilter = 0x2800,
        TextureMaxClampRSgix = 0x836B,
        TextureMaxClampSSgix = 0x8369,
        TextureMaxClampTSgix = 0x836A,
        TextureMaxLevelSgis = 0x813D,
        TextureMaxLodSgis = 0x813B,
        TextureMinFilter = 0x2801,
        TextureMinLodSgis = 0x813A,
        TexturePriority = 0x8066,
        TextureRedSize = 0x805C,
        TextureResident = 0x8067,
        TextureWidth = 0x1000,
        TextureWrapQSgis = 0x8137,
        TextureWrapRExt = 0x8072,
        TextureWrapS = 0x2802,
        TextureWrapT = 0x2803,
    }

    public enum GlHintMode : uint {
        DontCare = 0x1100,
        Fastest = 0x1101,
        Nicest = 0x1102,
    }

    public enum GlHintTarget : uint {
        AllowDrawFrgHintPgi = 0x1A210,
        AllowDrawMemHintPgi = 0x1A211,
        AllowDrawObjHintPgi = 0x1A20E,
        AllowDrawWinHintPgi = 0x1A20F,
        AlwaysFastHintPgi = 0x1A20C,
        AlwaysSoftHintPgi = 0x1A20D,
        BackNormalsHintPgi = 0x1A223,
        BinningControlHintQcom = 0x8FB0,
        ClipFarHintPgi = 0x1A221,
        ClipNearHintPgi = 0x1A220,
        ClipVolumeClippingHintExt = 0x80F0,
        ConserveMemoryHintPgi = 0x1A1FD,
        ConvolutionHintSgix = 0x8316,
        FogHint = 0x0C54,
        FragmentShaderDerivativeHint = 0x8B8B,
        FragmentShaderDerivativeHintArb = 0x8B8B,
        FragmentShaderDerivativeHintOes = 0x8B8B,
        FullStippleHintPgi = 0x1A219,
        GenerateMipmapHint = 0x8192,
        GenerateMipmapHintSgis = 0x8192,
        LineQualityHintSgix = 0x835B,
        LineSmoothHint = 0x0C52,
        MaterialSideHintPgi = 0x1A22C,
        MaxVertexHintPgi = 0x1A22D,
        MultisampleFilterHintNv = 0x8534,
        NativeGraphicsBeginHintPgi = 0x1A203,
        NativeGraphicsEndHintPgi = 0x1A204,
        PackCmykHintExt = 0x800E,
        PerspectiveCorrectionHint = 0x0C50,
        PhongHintWin = 0x80EB,
        PointSmoothHint = 0x0C51,
        PolygonSmoothHint = 0x0C53,
        PreferDoublebufferHintPgi = 0x1A1F8,
        ProgramBinaryRetrievableHint = 0x8257,
        ReclaimMemoryHintPgi = 0x1A1FE,
        ScalebiasHintSgix = 0x8322,
        StrictDepthfuncHintPgi = 0x1A216,
        StrictLightingHintPgi = 0x1A217,
        StrictScissorHintPgi = 0x1A218,
        TextureCompressionHint = 0x84EF,
        TextureCompressionHintArb = 0x84EF,
        TextureMultiBufferHintSgix = 0x812E,
        TextureStorageHintApple = 0x85BC,
        TransformHintApple = 0x85B1,
        UnpackCmykHintExt = 0x800F,
        VertexArrayStorageHintApple = 0x851F,
        VertexConsistentHintPgi = 0x1A22B,
        VertexDataHintPgi = 0x1A22A,
        VertexPreclipHintSgix = 0x83EF,
        VertexPreclipSgix = 0x83EE,
        WideLineHintPgi = 0x1A222,
    }

    public enum GlHistogramTargetEXT : uint {
        Histogram = 0x8024,
        HistogramExt = 0x8024,
        ProxyHistogram = 0x8025,
        ProxyHistogramExt = 0x8025,
    }

    public enum GlIndexPointerType : uint {
        Double = 0x140A,
        Float = 0x1406,
        Int = 0x1404,
        Short = 0x1402,
    }

    public enum GlInterleavedArrayFormat : uint {
        C3fV3f = 0x2A24,
        C4fN3fV3f = 0x2A26,
        C4ubV2f = 0x2A22,
        C4ubV3f = 0x2A23,
        N3fV3f = 0x2A25,
        T2fC3fV3f = 0x2A2A,
        T2fC4fN3fV3f = 0x2A2C,
        T2fC4ubV3f = 0x2A29,
        T2fN3fV3f = 0x2A2B,
        T2fV3f = 0x2A27,
        T4fC4fN3fV4f = 0x2A2D,
        T4fV4f = 0x2A28,
        V2f = 0x2A20,
        V3f = 0x2A21,
    }

    public enum GlLightEnvModeSGIX : uint {
        Add = 0x0104,
        Modulate = 0x2100,
        Replace = 0x1E01,
    }

    public enum GlLightEnvParameterSGIX : uint {
        LightEnvModeSgix = 0x8407,
    }

    public enum GlLightModelColorControl : uint {
        SeparateSpecularColor = 0x81FA,
        SeparateSpecularColorExt = 0x81FA,
        SingleColor = 0x81F9,
        SingleColorExt = 0x81F9,
    }

    public enum GlLightModelParameter : uint {
        LightModelAmbient = 0x0B53,
        LightModelColorControl = 0x81F8,
        LightModelColorControlExt = 0x81F8,
        LightModelLocalViewer = 0x0B51,
        LightModelTwoSide = 0x0B52,
    }

    public enum GlLightName : uint {
        FragmentLight0Sgix = 0x840C,
        FragmentLight1Sgix = 0x840D,
        FragmentLight2Sgix = 0x840E,
        FragmentLight3Sgix = 0x840F,
        FragmentLight4Sgix = 0x8410,
        FragmentLight5Sgix = 0x8411,
        FragmentLight6Sgix = 0x8412,
        FragmentLight7Sgix = 0x8413,
        Light0 = 0x4000,
        Light1 = 0x4001,
        Light2 = 0x4002,
        Light3 = 0x4003,
        Light4 = 0x4004,
        Light5 = 0x4005,
        Light6 = 0x4006,
        Light7 = 0x4007,
    }

    public enum GlLightParameter : uint {
        Ambient = 0x1200,
        ConstantAttenuation = 0x1207,
        Diffuse = 0x1201,
        LinearAttenuation = 0x1208,
        Position = 0x1203,
        QuadraticAttenuation = 0x1209,
        Specular = 0x1202,
        SpotCutoff = 0x1206,
        SpotDirection = 0x1204,
        SpotExponent = 0x1205,
    }

    public enum GlListMode : uint {
        Compile = 0x1300,
        CompileAndExecute = 0x1301,
    }

    public enum GlListNameType : uint {
        Gl2Bytes = 0x1407,
        Gl3Bytes = 0x1408,
        Gl4Bytes = 0x1409,
        Byte = 0x1400,
        Float = 0x1406,
        Int = 0x1404,
        Short = 0x1402,
        UnsignedByte = 0x1401,
        UnsignedInt = 0x1405,
        UnsignedShort = 0x1403,
    }

    public enum GlListParameterName : uint {
        ListPrioritySgix = 0x8182,
    }

    public enum GlLogicOp : uint {
        And = 0x1501,
        AndInverted = 0x1504,
        AndReverse = 0x1502,
        Clear = 0x1500,
        Copy = 0x1503,
        CopyInverted = 0x150C,
        Equiv = 0x1509,
        Invert = 0x150A,
        Nand = 0x150E,
        Noop = 0x1505,
        Nor = 0x1508,
        Or = 0x1507,
        OrInverted = 0x150D,
        OrReverse = 0x150B,
        Set = 0x150F,
        Xor = 0x1506,
    }

    public enum GlMapBufferUsageMask : uint {
        ClientStorageBit = 0x0200,
        ClientStorageBitExt = 0x0200,
        DynamicStorageBit = 0x0100,
        DynamicStorageBitExt = 0x0100,
        MapCoherentBit = 0x0080,
        MapCoherentBitExt = 0x0080,
        MapFlushExplicitBit = 0x0010,
        MapFlushExplicitBitExt = 0x0010,
        MapInvalidateBufferBit = 0x0008,
        MapInvalidateBufferBitExt = 0x0008,
        MapInvalidateRangeBit = 0x0004,
        MapInvalidateRangeBitExt = 0x0004,
        MapPersistentBit = 0x0040,
        MapPersistentBitExt = 0x0040,
        MapReadBit = 0x0001,
        MapReadBitExt = 0x0001,
        MapUnsynchronizedBit = 0x0020,
        MapUnsynchronizedBitExt = 0x0020,
        MapWriteBit = 0x0002,
        MapWriteBitExt = 0x0002,
        SparseStorageBitArb = 0x0400,
        LgpuSeparateStorageBitNvx = 0x0800,
        PerGpuStorageBitNv = 0x0800,
    }

    public enum GlMapTarget : uint {
        GeometryDeformationSgix = 0x8194,
        Map1Color4 = 0x0D90,
        Map1Index = 0x0D91,
        Map1Normal = 0x0D92,
        Map1TextureCoord1 = 0x0D93,
        Map1TextureCoord2 = 0x0D94,
        Map1TextureCoord3 = 0x0D95,
        Map1TextureCoord4 = 0x0D96,
        Map1Vertex3 = 0x0D97,
        Map1Vertex4 = 0x0D98,
        Map2Color4 = 0x0DB0,
        Map2Index = 0x0DB1,
        Map2Normal = 0x0DB2,
        Map2TextureCoord1 = 0x0DB3,
        Map2TextureCoord2 = 0x0DB4,
        Map2TextureCoord3 = 0x0DB5,
        Map2TextureCoord4 = 0x0DB6,
        Map2Vertex3 = 0x0DB7,
        Map2Vertex4 = 0x0DB8,
        TextureDeformationSgix = 0x8195,
    }

    public enum GlMapTextureFormatINTEL : uint {
        LayoutDefaultIntel = 0,
        LayoutLinearCpuCachedIntel = 2,
        LayoutLinearIntel = 1,
    }

    public enum GlMaterialFace : uint {
        Back = 0x0405,
        Front = 0x0404,
        FrontAndBack = 0x0408,
    }

    public enum GlMaterialParameter : uint {
        Ambient = 0x1200,
        AmbientAndDiffuse = 0x1602,
        ColorIndexes = 0x1603,
        Diffuse = 0x1201,
        Emission = 0x1600,
        Shininess = 0x1601,
        Specular = 0x1202,
    }

    public enum GlMatrixMode : uint {
        Modelview = 0x1700,
        Modelview0Ext = 0x1700,
        Projection = 0x1701,
        Texture = 0x1702,
    }

    public enum GlMemoryBarrierMask : uint {
        AllBarrierBits = 0xFFFFFFFF,
        AllBarrierBitsExt = 0xFFFFFFFF,
        AtomicCounterBarrierBit = 0x00001000,
        AtomicCounterBarrierBitExt = 0x00001000,
        BufferUpdateBarrierBit = 0x00000200,
        BufferUpdateBarrierBitExt = 0x00000200,
        ClientMappedBufferBarrierBit = 0x00004000,
        ClientMappedBufferBarrierBitExt = 0x00004000,
        CommandBarrierBit = 0x00000040,
        CommandBarrierBitExt = 0x00000040,
        ElementArrayBarrierBit = 0x00000002,
        ElementArrayBarrierBitExt = 0x00000002,
        FramebufferBarrierBit = 0x00000400,
        FramebufferBarrierBitExt = 0x00000400,
        PixelBufferBarrierBit = 0x00000080,
        PixelBufferBarrierBitExt = 0x00000080,
        QueryBufferBarrierBit = 0x00008000,
        ShaderGlobalAccessBarrierBitNv = 0x00000010,
        ShaderImageAccessBarrierBit = 0x00000020,
        ShaderImageAccessBarrierBitExt = 0x00000020,
        ShaderStorageBarrierBit = 0x00002000,
        TextureFetchBarrierBit = 0x00000008,
        TextureFetchBarrierBitExt = 0x00000008,
        TextureUpdateBarrierBit = 0x00000100,
        TextureUpdateBarrierBitExt = 0x00000100,
        TransformFeedbackBarrierBit = 0x00000800,
        TransformFeedbackBarrierBitExt = 0x00000800,
        UniformBarrierBit = 0x00000004,
        UniformBarrierBitExt = 0x00000004,
        VertexAttribArrayBarrierBit = 0x00000001,
        VertexAttribArrayBarrierBitExt = 0x00000001,
    }

    public enum GlMemoryObjectParameterName : uint {
        DedicatedMemoryObjectExt = 0x9581,
        ProtectedMemoryObjectExt = 0x959B,
    }

    public enum GlMeshMode1 : uint {
        Line = 0x1B01,
        Point = 0x1B00,
    }

    public enum GlMeshMode2 : uint {
        Fill = 0x1B02,
        Line = 0x1B01,
        Point = 0x1B00,
    }

    public enum GlMinmaxTargetEXT : uint {
        Minmax = 0x802E,
        MinmaxExt = 0x802E,
    }

    public enum GlNormalPointerType : uint {
        Byte = 0x1400,
        Double = 0x140A,
        Float = 0x1406,
        Int = 0x1404,
        Short = 0x1402,
    }

    public enum GlPixelCopyType : uint {
        Color = 0x1800,
        ColorExt = 0x1800,
        Depth = 0x1801,
        DepthExt = 0x1801,
        Stencil = 0x1802,
        StencilExt = 0x1802,
    }

    public enum GlPixelFormat : uint {
        AbgrExt = 0x8000,
        Alpha = 0x1906,
        Blue = 0x1905,
        CmykaExt = 0x800D,
        CmykExt = 0x800C,
        ColorIndex = 0x1900,
        DepthComponent = 0x1902,
        Green = 0x1904,
        Luminance = 0x1909,
        LuminanceAlpha = 0x190A,
        Red = 0x1903,
        RedExt = 0x1903,
        Rgb = 0x1907,
        Rgba = 0x1908,
        StencilIndex = 0x1901,
        UnsignedInt = 0x1405,
        UnsignedShort = 0x1403,
        Ycrcb422Sgix = 0x81BB,
        Ycrcb444Sgix = 0x81BC,
    }

    public enum GlInternalFormat : uint {
        Alpha12 = 0x803D,
        Alpha16 = 0x803E,
        Alpha4 = 0x803B,
        Alpha8 = 0x803C,
        DualAlpha12Sgis = 0x8112,
        DualAlpha16Sgis = 0x8113,
        DualAlpha4Sgis = 0x8110,
        DualAlpha8Sgis = 0x8111,
        DualIntensity12Sgis = 0x811A,
        DualIntensity16Sgis = 0x811B,
        DualIntensity4Sgis = 0x8118,
        DualIntensity8Sgis = 0x8119,
        DualLuminance12Sgis = 0x8116,
        DualLuminance16Sgis = 0x8117,
        DualLuminance4Sgis = 0x8114,
        DualLuminance8Sgis = 0x8115,
        DualLuminanceAlpha4Sgis = 0x811C,
        DualLuminanceAlpha8Sgis = 0x811D,
        Intensity = 0x8049,
        Intensity12 = 0x804C,
        Intensity16 = 0x804D,
        Intensity4 = 0x804A,
        Intensity8 = 0x804B,
        Luminance12 = 0x8041,
        Luminance12Alpha12 = 0x8047,
        Luminance12Alpha4 = 0x8046,
        Luminance16 = 0x8042,
        Luminance16Alpha16 = 0x8048,
        Luminance4 = 0x803F,
        Luminance4Alpha4 = 0x8043,
        Luminance6Alpha2 = 0x8044,
        Luminance8 = 0x8040,
        Luminance8Alpha8 = 0x8045,
        QuadAlpha4Sgis = 0x811E,
        QuadAlpha8Sgis = 0x811F,
        QuadIntensity4Sgis = 0x8122,
        QuadIntensity8Sgis = 0x8123,
        QuadLuminance4Sgis = 0x8120,
        QuadLuminance8Sgis = 0x8121,
        Red = 0x1903,
        RedExt = 0x1903,
        R8 = 0x8229,
        R8Ext = 0x8229,
        R8Snorm = 0x8F94,
        R16 = 0x822A,
        R16Ext = 0x822A,
        R16Snorm = 0x8F98,
        R16SnormExt = 0x8F98,
        R16f = 0x822D,
        R16fExt = 0x822D,
        R32f = 0x822E,
        R32fExt = 0x822E,
        R8i = 0x8231,
        R16i = 0x8233,
        R32i = 0x8235,
        R8ui = 0x8232,
        R16ui = 0x8234,
        R32ui = 0x8236,
        Rg = 0x8227,
        Rg8 = 0x822B,
        Rg8Ext = 0x822B,
        Rg8Snorm = 0x8F95,
        Rg16 = 0x822C,
        Rg16Ext = 0x822C,
        Rg16Snorm = 0x8F99,
        Rg16SnormExt = 0x8F99,
        Rg16f = 0x822F,
        Rg16fExt = 0x822F,
        Rg32f = 0x8230,
        Rg32fExt = 0x8230,
        Rg8i = 0x8237,
        Rg16i = 0x8239,
        Rg32i = 0x823B,
        Rg8ui = 0x8238,
        Rg16ui = 0x823A,
        Rg32ui = 0x823C,
        Rgb = 0x1907,
        Rgb2Ext = 0x804E,
        Rgb4 = 0x804F,
        Rgb4Ext = 0x804F,
        Rgb5 = 0x8050,
        Rgb5Ext = 0x8050,
        Rgb8 = 0x8051,
        Rgb8Ext = 0x8051,
        Rgb8Oes = 0x8051,
        Rgb8Snorm = 0x8F96,
        Rgb10 = 0x8052,
        Rgb10Ext = 0x8052,
        Rgb12 = 0x8053,
        Rgb12Ext = 0x8053,
        Rgb16 = 0x8054,
        Rgb16Ext = 0x8054,
        Rgb16f = 0x881B,
        Rgb16fArb = 0x881B,
        Rgb16fExt = 0x881B,
        Rgb16Snorm = 0x8F9A,
        Rgb16SnormExt = 0x8F9A,
        Rgb8i = 0x8D8F,
        Rgb16i = 0x8D89,
        Rgb32i = 0x8D83,
        Rgb8ui = 0x8D7D,
        Rgb16ui = 0x8D77,
        Rgb32ui = 0x8D71,
        Srgb = 0x8C40,
        SrgbExt = 0x8C40,
        SrgbAlpha = 0x8C42,
        SrgbAlphaExt = 0x8C42,
        Srgb8 = 0x8C41,
        Srgb8Ext = 0x8C41,
        Srgb8Nv = 0x8C41,
        Srgb8Alpha8 = 0x8C43,
        Srgb8Alpha8Ext = 0x8C43,
        R3G3B2 = 0x2A10,
        R11fG11fB10f = 0x8C3A,
        R11fG11fB10fApple = 0x8C3A,
        R11fG11fB10fExt = 0x8C3A,
        Rgb9E5 = 0x8C3D,
        Rgb9E5Apple = 0x8C3D,
        Rgb9E5Ext = 0x8C3D,
        Rgba = 0x1908,
        Rgba4 = 0x8056,
        Rgba4Ext = 0x8056,
        Rgba4Oes = 0x8056,
        Rgb5A1 = 0x8057,
        Rgb5A1Ext = 0x8057,
        Rgb5A1Oes = 0x8057,
        Rgba8 = 0x8058,
        Rgba8Ext = 0x8058,
        Rgba8Oes = 0x8058,
        Rgba8Snorm = 0x8F97,
        Rgb10A2 = 0x8059,
        Rgb10A2Ext = 0x8059,
        Rgba12 = 0x805A,
        Rgba12Ext = 0x805A,
        Rgba16 = 0x805B,
        Rgba16Ext = 0x805B,
        Rgba16f = 0x881A,
        Rgba16fArb = 0x881A,
        Rgba16fExt = 0x881A,
        Rgba32f = 0x8814,
        Rgba32fArb = 0x8814,
        Rgba32fExt = 0x8814,
        Rgba8i = 0x8D8E,
        Rgba16i = 0x8D88,
        Rgba32i = 0x8D82,
        Rgba8ui = 0x8D7C,
        Rgba16ui = 0x8D76,
        Rgba32ui = 0x8D70,
        Rgb10A2ui = 0x906F,
        DepthComponent = 0x1902,
        DepthComponent16 = 0x81A5,
        DepthComponent16Arb = 0x81A5,
        DepthComponent16Oes = 0x81A5,
        DepthComponent16Sgix = 0x81A5,
        DepthComponent24Arb = 0x81A6,
        DepthComponent24Oes = 0x81A6,
        DepthComponent24Sgix = 0x81A6,
        DepthComponent32Arb = 0x81A7,
        DepthComponent32Oes = 0x81A7,
        DepthComponent32Sgix = 0x81A7,
        DepthComponent32f = 0x8CAC,
        DepthComponent32fNv = 0x8DAB,
        DepthStencil = 0x84F9,
        DepthStencilExt = 0x84F9,
        DepthStencilMesa = 0x8750,
        DepthStencilNv = 0x84F9,
        DepthStencilOes = 0x84F9,
        Depth24Stencil8 = 0x88F0,
        Depth24Stencil8Ext = 0x88F0,
        Depth24Stencil8Oes = 0x88F0,
        Depth32fStencil8 = 0x8CAD,
        Depth32fStencil8Nv = 0x8DAC,
        CompressedRed = 0x8225,
        CompressedRg = 0x8226,
        CompressedRgb = 0x84ED,
        CompressedRgba = 0x84EE,
        CompressedSrgb = 0x8C48,
        CompressedSrgbAlpha = 0x8C49,
        CompressedRedRgtc1 = 0x8DBB,
        CompressedRedRgtc1Ext = 0x8DBB,
        CompressedSignedRedRgtc1 = 0x8DBC,
        CompressedSignedRedRgtc1Ext = 0x8DBC,
        CompressedR11Eac = 0x9270,
        CompressedSignedR11Eac = 0x9271,
        CompressedRgRgtc2 = 0x8DBD,
        CompressedSignedRgRgtc2 = 0x8DBE,
        CompressedRgbaBptcUnorm = 0x8E8C,
        CompressedSrgbAlphaBptcUnorm = 0x8E8D,
        CompressedRgbBptcSignedFloat = 0x8E8E,
        CompressedRgbBptcUnsignedFloat = 0x8E8F,
        CompressedRgb8Etc2 = 0x9274,
        CompressedSrgb8Etc2 = 0x9275,
        CompressedRgb8PunchthroughAlpha1Etc2 = 0x9276,
        CompressedSrgb8PunchthroughAlpha1Etc2 = 0x9277,
        CompressedRgba8Etc2Eac = 0x9278,
        CompressedSrgb8Alpha8Etc2Eac = 0x9279,
        CompressedRg11Eac = 0x9272,
        CompressedSignedRg11Eac = 0x9273,
        CompressedRgbS3tcDxt1Ext = 0x83F0,
        CompressedSrgbS3tcDxt1Ext = 0x8C4C,
        CompressedRgbaS3tcDxt1Ext = 0x83F1,
        CompressedSrgbAlphaS3tcDxt1Ext = 0x8C4D,
        CompressedRgbaS3tcDxt3Ext = 0x83F2,
        CompressedSrgbAlphaS3tcDxt3Ext = 0x8C4E,
        CompressedRgbaS3tcDxt5Ext = 0x83F3,
        CompressedSrgbAlphaS3tcDxt5Ext = 0x8C4F,
    }

    public enum GlPixelMap : uint {
        PixelMapAToA = 0x0C79,
        PixelMapBToB = 0x0C78,
        PixelMapGToG = 0x0C77,
        PixelMapIToA = 0x0C75,
        PixelMapIToB = 0x0C74,
        PixelMapIToG = 0x0C73,
        PixelMapIToI = 0x0C70,
        PixelMapIToR = 0x0C72,
        PixelMapRToR = 0x0C76,
        PixelMapSToS = 0x0C71,
    }

    public enum GlPixelStoreParameter : uint {
        PackAlignment = 0x0D05,
        PackImageDepthSgis = 0x8131,
        PackImageHeight = 0x806C,
        PackImageHeightExt = 0x806C,
        PackLsbFirst = 0x0D01,
        PackResampleOml = 0x8984,
        PackResampleSgix = 0x842E,
        PackRowLength = 0x0D02,
        PackSkipImages = 0x806B,
        PackSkipImagesExt = 0x806B,
        PackSkipPixels = 0x0D04,
        PackSkipRows = 0x0D03,
        PackSkipVolumesSgis = 0x8130,
        PackSubsampleRateSgix = 0x85A0,
        PackSwapBytes = 0x0D00,
        PixelTileCacheSizeSgix = 0x8145,
        PixelTileGridDepthSgix = 0x8144,
        PixelTileGridHeightSgix = 0x8143,
        PixelTileGridWidthSgix = 0x8142,
        PixelTileHeightSgix = 0x8141,
        PixelTileWidthSgix = 0x8140,
        UnpackAlignment = 0x0CF5,
        UnpackImageDepthSgis = 0x8133,
        UnpackImageHeight = 0x806E,
        UnpackImageHeightExt = 0x806E,
        UnpackLsbFirst = 0x0CF1,
        UnpackResampleOml = 0x8985,
        UnpackResampleSgix = 0x842F,
        UnpackRowLength = 0x0CF2,
        UnpackRowLengthExt = 0x0CF2,
        UnpackSkipImages = 0x806D,
        UnpackSkipImagesExt = 0x806D,
        UnpackSkipPixels = 0x0CF4,
        UnpackSkipPixelsExt = 0x0CF4,
        UnpackSkipRows = 0x0CF3,
        UnpackSkipRowsExt = 0x0CF3,
        UnpackSkipVolumesSgis = 0x8132,
        UnpackSubsampleRateSgix = 0x85A1,
        UnpackSwapBytes = 0x0CF0,
    }

    public enum GlPixelStoreResampleMode : uint {
        ResampleDecimateSgix = 0x8430,
        ResampleReplicateSgix = 0x8433,
        ResampleZeroFillSgix = 0x8434,
    }

    public enum GlPixelStoreSubsampleRate : uint {
        PixelSubsample2424Sgix = 0x85A3,
        PixelSubsample4242Sgix = 0x85A4,
        PixelSubsample4444Sgix = 0x85A2,
    }

    public enum GlPixelTexGenMode : uint {
        Luminance = 0x1909,
        LuminanceAlpha = 0x190A,
        None = 0,
        PixelTexGenAlphaLsSgix = 0x8189,
        PixelTexGenAlphaMsSgix = 0x818A,
        PixelTexGenAlphaNoReplaceSgix = 0x8188,
        PixelTexGenAlphaReplaceSgix = 0x8187,
        Rgb = 0x1907,
        Rgba = 0x1908,
    }

    public enum GlPixelTexGenParameterNameSGIS : uint {
        PixelFragmentAlphaSourceSgis = 0x8355,
        PixelFragmentRgbSourceSgis = 0x8354,
    }

    public enum GlPixelTransferParameter : uint {
        AlphaBias = 0x0D1D,
        AlphaScale = 0x0D1C,
        BlueBias = 0x0D1B,
        BlueScale = 0x0D1A,
        DepthBias = 0x0D1F,
        DepthScale = 0x0D1E,
        GreenBias = 0x0D19,
        GreenScale = 0x0D18,
        IndexOffset = 0x0D13,
        IndexShift = 0x0D12,
        MapColor = 0x0D10,
        MapStencil = 0x0D11,
        PostColorMatrixAlphaBias = 0x80BB,
        PostColorMatrixAlphaBiasSgi = 0x80BB,
        PostColorMatrixAlphaScale = 0x80B7,
        PostColorMatrixAlphaScaleSgi = 0x80B7,
        PostColorMatrixBlueBias = 0x80BA,
        PostColorMatrixBlueBiasSgi = 0x80BA,
        PostColorMatrixBlueScale = 0x80B6,
        PostColorMatrixBlueScaleSgi = 0x80B6,
        PostColorMatrixGreenBias = 0x80B9,
        PostColorMatrixGreenBiasSgi = 0x80B9,
        PostColorMatrixGreenScale = 0x80B5,
        PostColorMatrixGreenScaleSgi = 0x80B5,
        PostColorMatrixRedBias = 0x80B8,
        PostColorMatrixRedBiasSgi = 0x80B8,
        PostColorMatrixRedScale = 0x80B4,
        PostColorMatrixRedScaleSgi = 0x80B4,
        PostConvolutionAlphaBias = 0x8023,
        PostConvolutionAlphaBiasExt = 0x8023,
        PostConvolutionAlphaScale = 0x801F,
        PostConvolutionAlphaScaleExt = 0x801F,
        PostConvolutionBlueBias = 0x8022,
        PostConvolutionBlueBiasExt = 0x8022,
        PostConvolutionBlueScale = 0x801E,
        PostConvolutionBlueScaleExt = 0x801E,
        PostConvolutionGreenBias = 0x8021,
        PostConvolutionGreenBiasExt = 0x8021,
        PostConvolutionGreenScale = 0x801D,
        PostConvolutionGreenScaleExt = 0x801D,
        PostConvolutionRedBias = 0x8020,
        PostConvolutionRedBiasExt = 0x8020,
        PostConvolutionRedScale = 0x801C,
        PostConvolutionRedScaleExt = 0x801C,
        RedBias = 0x0D15,
        RedScale = 0x0D14,
    }

    public enum GlPixelType : uint {
        Bitmap = 0x1A00,
        Byte = 0x1400,
        Float = 0x1406,
        Int = 0x1404,
        Short = 0x1402,
        UnsignedByte = 0x1401,
        UnsignedByte332 = 0x8032,
        UnsignedByte332Ext = 0x8032,
        UnsignedInt = 0x1405,
        UnsignedInt1010102 = 0x8036,
        UnsignedInt1010102Ext = 0x8036,
        UnsignedInt8888 = 0x8035,
        UnsignedInt8888Ext = 0x8035,
        UnsignedShort = 0x1403,
        UnsignedShort4444 = 0x8033,
        UnsignedShort4444Ext = 0x8033,
        UnsignedShort5551 = 0x8034,
        UnsignedShort5551Ext = 0x8034,
    }

    public enum GlPointParameterNameSGIS : uint {
        DistanceAttenuationExt = 0x8129,
        DistanceAttenuationSgis = 0x8129,
        PointDistanceAttenuation = 0x8129,
        PointDistanceAttenuationArb = 0x8129,
        PointFadeThresholdSize = 0x8128,
        PointFadeThresholdSizeArb = 0x8128,
        PointFadeThresholdSizeExt = 0x8128,
        PointFadeThresholdSizeSgis = 0x8128,
        PointSizeMax = 0x8127,
        PointSizeMaxArb = 0x8127,
        PointSizeMaxExt = 0x8127,
        PointSizeMaxSgis = 0x8127,
        PointSizeMin = 0x8126,
        PointSizeMinArb = 0x8126,
        PointSizeMinExt = 0x8126,
        PointSizeMinSgis = 0x8126,
    }

    public enum GlPolygonMode : uint {
        Fill = 0x1B02,
        Line = 0x1B01,
        Point = 0x1B00,
    }

    public enum GlPrimitiveType : uint {
        Lines = 0x0001,
        LinesAdjacency = 0x000A,
        LinesAdjacencyArb = 0x000A,
        LinesAdjacencyExt = 0x000A,
        LineLoop = 0x0002,
        LineStrip = 0x0003,
        LineStripAdjacency = 0x000B,
        LineStripAdjacencyArb = 0x000B,
        LineStripAdjacencyExt = 0x000B,
        Patches = 0x000E,
        PatchesExt = 0x000E,
        Points = 0x0000,
        Polygon = 0x0009,
        Quads = 0x0007,
        QuadsExt = 0x0007,
        QuadStrip = 0x0008,
        Triangles = 0x0004,
        TrianglesAdjacency = 0x000C,
        TrianglesAdjacencyArb = 0x000C,
        TrianglesAdjacencyExt = 0x000C,
        TriangleFan = 0x0006,
        TriangleStrip = 0x0005,
        TriangleStripAdjacency = 0x000D,
        TriangleStripAdjacencyArb = 0x000D,
        TriangleStripAdjacencyExt = 0x000D,
    }

    public enum GlOcclusionQueryEventMaskAMD : uint {
        QueryDepthPassEventBitAmd = 0x00000001,
        QueryDepthFailEventBitAmd = 0x00000002,
        QueryStencilFailEventBitAmd = 0x00000004,
        QueryDepthBoundsFailEventBitAmd = 0x00000008,
        QueryAllEventBitsAmd = 0xFFFFFFFF,
    }

    public enum GlReadBufferMode : uint {
        Aux0 = 0x0409,
        Aux1 = 0x040A,
        Aux2 = 0x040B,
        Aux3 = 0x040C,
        Back = 0x0405,
        BackLeft = 0x0402,
        BackRight = 0x0403,
        Front = 0x0404,
        FrontLeft = 0x0400,
        FrontRight = 0x0401,
        Left = 0x0406,
        Right = 0x0407,
    }

    public enum GlRenderingMode : uint {
        Feedback = 0x1C01,
        Render = 0x1C00,
        Select = 0x1C02,
    }

    public enum GlSamplePatternSGIS : uint {
        Gl1passExt = 0x80A1,
        Gl1passSgis = 0x80A1,
        Gl2pass0Ext = 0x80A2,
        Gl2pass0Sgis = 0x80A2,
        Gl2pass1Ext = 0x80A3,
        Gl2pass1Sgis = 0x80A3,
        Gl4pass0Ext = 0x80A4,
        Gl4pass0Sgis = 0x80A4,
        Gl4pass1Ext = 0x80A5,
        Gl4pass1Sgis = 0x80A5,
        Gl4pass2Ext = 0x80A6,
        Gl4pass2Sgis = 0x80A6,
        Gl4pass3Ext = 0x80A7,
        Gl4pass3Sgis = 0x80A7,
    }

    public enum GlSemaphoreParameterName : uint {
        D3d12FenceValueExt = 0x9595,
    }

    public enum GlSeparableTargetEXT : uint {
        Separable2d = 0x8012,
        Separable2dExt = 0x8012,
    }

    public enum GlShadingModel : uint {
        Flat = 0x1D00,
        Smooth = 0x1D01,
    }

    public enum GlStencilFaceDirection : uint {
        Front = 0x0404,
        Back = 0x0405,
        FrontAndBack = 0x0408,
    }

    public enum GlStencilFunction : uint {
        Always = 0x0207,
        Equal = 0x0202,
        Gequal = 0x0206,
        Greater = 0x0204,
        Lequal = 0x0203,
        Less = 0x0201,
        Never = 0x0200,
        Notequal = 0x0205,
    }

    public enum GlStencilOp : uint {
        Decr = 0x1E03,
        Incr = 0x1E02,
        Invert = 0x150A,
        Keep = 0x1E00,
        Replace = 0x1E01,
        Zero = 0,
    }

    public enum GlStringName : uint {
        Extensions = 0x1F03,
        Renderer = 0x1F01,
        Vendor = 0x1F00,
        Version = 0x1F02,
        ShadingLanguageVersion = 0x8B8C,
    }

    public enum GlSyncObjectMask : uint {
        SyncFlushCommandsBit = 0x00000001,
        SyncFlushCommandsBitApple = 0x00000001,
    }

    public enum GlTexCoordPointerType : uint {
        Double = 0x140A,
        Float = 0x1406,
        Int = 0x1404,
        Short = 0x1402,
    }

    public enum GlTextureCoordName : uint {
        S = 0x2000,
        T = 0x2001,
        R = 0x2002,
        Q = 0x2003,
    }

    public enum GlTextureEnvMode : uint {
        Add = 0x0104,
        Blend = 0x0BE2,
        Decal = 0x2101,
        Modulate = 0x2100,
        ReplaceExt = 0x8062,
        TextureEnvBiasSgix = 0x80BE,
    }

    public enum GlTextureEnvParameter : uint {
        TextureEnvColor = 0x2201,
        TextureEnvMode = 0x2200,
    }

    public enum GlTextureEnvTarget : uint {
        TextureEnv = 0x2300,
    }

    public enum GlTextureFilterFuncSGIS : uint {
        Filter4Sgis = 0x8146,
    }

    public enum GlTextureGenMode : uint {
        EyeDistanceToLineSgis = 0x81F2,
        EyeDistanceToPointSgis = 0x81F0,
        EyeLinear = 0x2400,
        ObjectDistanceToLineSgis = 0x81F3,
        ObjectDistanceToPointSgis = 0x81F1,
        ObjectLinear = 0x2401,
        SphereMap = 0x2402,
    }

    public enum GlTextureGenParameter : uint {
        EyeLineSgis = 0x81F6,
        EyePlane = 0x2502,
        EyePointSgis = 0x81F4,
        ObjectLineSgis = 0x81F7,
        ObjectPlane = 0x2501,
        ObjectPointSgis = 0x81F5,
        TextureGenMode = 0x2500,
    }

    public enum GlTextureMagFilter : uint {
        Filter4Sgis = 0x8146,
        Linear = 0x2601,
        LinearDetailAlphaSgis = 0x8098,
        LinearDetailColorSgis = 0x8099,
        LinearDetailSgis = 0x8097,
        LinearSharpenAlphaSgis = 0x80AE,
        LinearSharpenColorSgis = 0x80AF,
        LinearSharpenSgis = 0x80AD,
        Nearest = 0x2600,
        PixelTexGenQCeilingSgix = 0x8184,
        PixelTexGenQFloorSgix = 0x8186,
        PixelTexGenQRoundSgix = 0x8185,
    }

    public enum GlTextureMinFilter : uint {
        Filter4Sgis = 0x8146,
        Linear = 0x2601,
        LinearClipmapLinearSgix = 0x8170,
        LinearClipmapNearestSgix = 0x844F,
        LinearMipmapLinear = 0x2703,
        LinearMipmapNearest = 0x2701,
        Nearest = 0x2600,
        NearestClipmapLinearSgix = 0x844E,
        NearestClipmapNearestSgix = 0x844D,
        NearestMipmapLinear = 0x2702,
        NearestMipmapNearest = 0x2700,
        PixelTexGenQCeilingSgix = 0x8184,
        PixelTexGenQFloorSgix = 0x8186,
        PixelTexGenQRoundSgix = 0x8185,
    }

    public enum GlTextureParameterName : uint {
        DetailTextureLevelSgis = 0x809A,
        DetailTextureModeSgis = 0x809B,
        DualTextureSelectSgis = 0x8124,
        GenerateMipmap = 0x8191,
        GenerateMipmapSgis = 0x8191,
        PostTextureFilterBiasSgix = 0x8179,
        PostTextureFilterScaleSgix = 0x817A,
        QuadTextureSelectSgis = 0x8125,
        ShadowAmbientSgix = 0x80BF,
        TextureBorderColor = 0x1004,
        TextureClipmapCenterSgix = 0x8171,
        TextureClipmapDepthSgix = 0x8176,
        TextureClipmapFrameSgix = 0x8172,
        TextureClipmapLodOffsetSgix = 0x8175,
        TextureClipmapOffsetSgix = 0x8173,
        TextureClipmapVirtualDepthSgix = 0x8174,
        TextureCompareSgix = 0x819A,
        TextureLodBiasRSgix = 0x8190,
        TextureLodBiasSSgix = 0x818E,
        TextureLodBiasTSgix = 0x818F,
        TextureMagFilter = 0x2800,
        TextureMaxClampRSgix = 0x836B,
        TextureMaxClampSSgix = 0x8369,
        TextureMaxClampTSgix = 0x836A,
        TextureMinFilter = 0x2801,
        TexturePriority = 0x8066,
        TexturePriorityExt = 0x8066,
        TextureWrapQSgis = 0x8137,
        TextureWrapR = 0x8072,
        TextureWrapRExt = 0x8072,
        TextureWrapROes = 0x8072,
        TextureWrapS = 0x2802,
        TextureWrapT = 0x2803,
        TextureBaseLevel = 0x813C,
        TextureCompareMode = 0x884C,
        TextureCompareFunc = 0x884D,
        TextureLodBias = 0x8501,
        TextureMinLod = 0x813A,
        TextureMaxLod = 0x813B,
        TextureMaxLevel = 0x813D,
        TextureSwizzleR = 0x8E42,
        TextureSwizzleG = 0x8E43,
        TextureSwizzleB = 0x8E44,
        TextureSwizzleA = 0x8E45,
        TextureSwizzleRgba = 0x8E46,
        TextureTilingExt = 0x9580,
        DepthStencilTextureMode = 0x90EA,
        DetailTextureFuncPointsSgis = 0x809C,
        SharpenTextureFuncPointsSgis = 0x80B0,
        Texture4dsizeSgis = 0x8136,
        TextureAlphaSize = 0x805F,
        TextureBaseLevelSgis = 0x813C,
        TextureBlueSize = 0x805E,
        TextureBorder = 0x1005,
        TextureBorderColorNv = 0x1004,
        TextureCompareOperatorSgix = 0x819B,
        TextureComponents = 0x1003,
        TextureDepthExt = 0x8071,
        TextureFilter4SizeSgis = 0x8147,
        TextureGequalRSgix = 0x819D,
        TextureGreenSize = 0x805D,
        TextureHeight = 0x1001,
        TextureIntensitySize = 0x8061,
        TextureInternalFormat = 0x1003,
        TextureLequalRSgix = 0x819C,
        TextureLuminanceSize = 0x8060,
        TextureMaxLevelSgis = 0x813D,
        TextureMaxLodSgis = 0x813B,
        TextureMinLodSgis = 0x813A,
        TextureRedSize = 0x805C,
        TextureResident = 0x8067,
        TextureWidth = 0x1000,
    }

    public enum GlTextureStorageMaskAMD : uint {
        TextureStorageSparseBitAmd = 0x00000001,
    }

    public enum GlTextureTarget : uint {
        DetailTexture2dSgis = 0x8095,
        ProxyTexture1d = 0x8063,
        ProxyTexture1dArray = 0x8C19,
        ProxyTexture1dArrayExt = 0x8C19,
        ProxyTexture1dExt = 0x8063,
        ProxyTexture2d = 0x8064,
        ProxyTexture2dArray = 0x8C1B,
        ProxyTexture2dArrayExt = 0x8C1B,
        ProxyTexture2dExt = 0x8064,
        ProxyTexture2dMultisample = 0x9101,
        ProxyTexture2dMultisampleArray = 0x9103,
        ProxyTexture3d = 0x8070,
        ProxyTexture3dExt = 0x8070,
        ProxyTexture4dSgis = 0x8135,
        ProxyTextureCubeMap = 0x851B,
        ProxyTextureCubeMapArb = 0x851B,
        ProxyTextureCubeMapExt = 0x851B,
        ProxyTextureCubeMapArray = 0x900B,
        ProxyTextureCubeMapArrayArb = 0x900B,
        ProxyTextureRectangle = 0x84F7,
        ProxyTextureRectangleArb = 0x84F7,
        ProxyTextureRectangleNv = 0x84F7,
        Texture1d = 0x0DE0,
        Texture2d = 0x0DE1,
        Texture3d = 0x806F,
        Texture3dExt = 0x806F,
        Texture3dOes = 0x806F,
        Texture4dSgis = 0x8134,
        TextureRectangle = 0x84F5,
        TextureCubeMap = 0x8513,
        TextureCubeMapPositiveX = 0x8515,
        TextureCubeMapNegativeX = 0x8516,
        TextureCubeMapPositiveY = 0x8517,
        TextureCubeMapNegativeY = 0x8518,
        TextureCubeMapPositiveZ = 0x8519,
        TextureCubeMapNegativeZ = 0x851A,
        TextureCubeMapArray = 0x9009,
        TextureCubeMapArrayArb = 0x9009,
        TextureCubeMapArrayExt = 0x9009,
        TextureCubeMapArrayOes = 0x9009,
        Texture1dArray = 0x8C18,
        Texture2dArray = 0x8C1A,
        Texture2dMultisample = 0x9100,
        Texture2dMultisampleArray = 0x9102,
    }

    public enum GlTextureWrapMode : uint {
        Clamp = 0x2900,
        ClampToBorder = 0x812D,
        ClampToBorderArb = 0x812D,
        ClampToBorderNv = 0x812D,
        ClampToBorderSgis = 0x812D,
        ClampToEdge = 0x812F,
        ClampToEdgeSgis = 0x812F,
        Repeat = 0x2901,
    }

    public enum GlUseProgramStageMask : uint {
        VertexShaderBit = 0x00000001,
        VertexShaderBitExt = 0x00000001,
        FragmentShaderBit = 0x00000002,
        FragmentShaderBitExt = 0x00000002,
        GeometryShaderBit = 0x00000004,
        GeometryShaderBitExt = 0x00000004,
        GeometryShaderBitOes = 0x00000004,
        TessControlShaderBit = 0x00000008,
        TessControlShaderBitExt = 0x00000008,
        TessControlShaderBitOes = 0x00000008,
        TessEvaluationShaderBit = 0x00000010,
        TessEvaluationShaderBitExt = 0x00000010,
        TessEvaluationShaderBitOes = 0x00000010,
        ComputeShaderBit = 0x00000020,
        AllShaderBits = 0xFFFFFFFF,
        AllShaderBitsExt = 0xFFFFFFFF,
    }

    public enum GlVertexPointerType : uint {
        Double = 0x140A,
        Float = 0x1406,
        Int = 0x1404,
        Short = 0x1402,
    }

    public enum GlFramebufferAttachment : uint {
        MaxColorAttachments = 0x8CDF,
        MaxColorAttachmentsExt = 0x8CDF,
        MaxColorAttachmentsNv = 0x8CDF,
        ColorAttachment0 = 0x8CE0,
        ColorAttachment0Ext = 0x8CE0,
        ColorAttachment0Nv = 0x8CE0,
        ColorAttachment0Oes = 0x8CE0,
        ColorAttachment1 = 0x8CE1,
        ColorAttachment1Ext = 0x8CE1,
        ColorAttachment1Nv = 0x8CE1,
        ColorAttachment2 = 0x8CE2,
        ColorAttachment2Ext = 0x8CE2,
        ColorAttachment2Nv = 0x8CE2,
        ColorAttachment3 = 0x8CE3,
        ColorAttachment3Ext = 0x8CE3,
        ColorAttachment3Nv = 0x8CE3,
        ColorAttachment4 = 0x8CE4,
        ColorAttachment4Ext = 0x8CE4,
        ColorAttachment4Nv = 0x8CE4,
        ColorAttachment5 = 0x8CE5,
        ColorAttachment5Ext = 0x8CE5,
        ColorAttachment5Nv = 0x8CE5,
        ColorAttachment6 = 0x8CE6,
        ColorAttachment6Ext = 0x8CE6,
        ColorAttachment6Nv = 0x8CE6,
        ColorAttachment7 = 0x8CE7,
        ColorAttachment7Ext = 0x8CE7,
        ColorAttachment7Nv = 0x8CE7,
        ColorAttachment8 = 0x8CE8,
        ColorAttachment8Ext = 0x8CE8,
        ColorAttachment8Nv = 0x8CE8,
        ColorAttachment9 = 0x8CE9,
        ColorAttachment9Ext = 0x8CE9,
        ColorAttachment9Nv = 0x8CE9,
        ColorAttachment10 = 0x8CEA,
        ColorAttachment10Ext = 0x8CEA,
        ColorAttachment10Nv = 0x8CEA,
        ColorAttachment11 = 0x8CEB,
        ColorAttachment11Ext = 0x8CEB,
        ColorAttachment11Nv = 0x8CEB,
        ColorAttachment12 = 0x8CEC,
        ColorAttachment12Ext = 0x8CEC,
        ColorAttachment12Nv = 0x8CEC,
        ColorAttachment13 = 0x8CED,
        ColorAttachment13Ext = 0x8CED,
        ColorAttachment13Nv = 0x8CED,
        ColorAttachment14 = 0x8CEE,
        ColorAttachment14Ext = 0x8CEE,
        ColorAttachment14Nv = 0x8CEE,
        ColorAttachment15 = 0x8CEF,
        ColorAttachment15Ext = 0x8CEF,
        ColorAttachment15Nv = 0x8CEF,
        ColorAttachment16 = 0x8CF0,
        ColorAttachment17 = 0x8CF1,
        ColorAttachment18 = 0x8CF2,
        ColorAttachment19 = 0x8CF3,
        ColorAttachment20 = 0x8CF4,
        ColorAttachment21 = 0x8CF5,
        ColorAttachment22 = 0x8CF6,
        ColorAttachment23 = 0x8CF7,
        ColorAttachment24 = 0x8CF8,
        ColorAttachment25 = 0x8CF9,
        ColorAttachment26 = 0x8CFA,
        ColorAttachment27 = 0x8CFB,
        ColorAttachment28 = 0x8CFC,
        ColorAttachment29 = 0x8CFD,
        ColorAttachment30 = 0x8CFE,
        ColorAttachment31 = 0x8CFF,
        DepthAttachment = 0x8D00,
        DepthAttachmentExt = 0x8D00,
        DepthAttachmentOes = 0x8D00,
    }

    public enum GlRenderbufferTarget : uint {
        Renderbuffer = 0x8D41,
    }

    public enum GlFramebufferTarget : uint {
        Framebuffer = 0x8D40,
        DrawFramebuffer = 0x8CA9,
        ReadFramebuffer = 0x8CA8,
    }

    public enum GlTextureUnit : uint {
        Texture0 = 0x84C0,
        Texture1 = 0x84C1,
        Texture2 = 0x84C2,
        Texture3 = 0x84C3,
        Texture4 = 0x84C4,
        Texture5 = 0x84C5,
        Texture6 = 0x84C6,
        Texture7 = 0x84C7,
        Texture8 = 0x84C8,
        Texture9 = 0x84C9,
        Texture10 = 0x84CA,
        Texture11 = 0x84CB,
        Texture12 = 0x84CC,
        Texture13 = 0x84CD,
        Texture14 = 0x84CE,
        Texture15 = 0x84CF,
        Texture16 = 0x84D0,
        Texture17 = 0x84D1,
        Texture18 = 0x84D2,
        Texture19 = 0x84D3,
        Texture20 = 0x84D4,
        Texture21 = 0x84D5,
        Texture22 = 0x84D6,
        Texture23 = 0x84D7,
        Texture24 = 0x84D8,
        Texture25 = 0x84D9,
        Texture26 = 0x84DA,
        Texture27 = 0x84DB,
        Texture28 = 0x84DC,
        Texture29 = 0x84DD,
        Texture30 = 0x84DE,
        Texture31 = 0x84DF,
    }

    public enum GlTypeEnum : uint {
        QueryWait = 0x8E13,
        QueryNoWait = 0x8E14,
        QueryByRegionWait = 0x8E15,
        QueryByRegionNoWait = 0x8E16,
    }

    public enum GlFragmentOpATI : uint {
        MovAti = 0x8961,
        AddAti = 0x8963,
        MulAti = 0x8964,
        SubAti = 0x8965,
        Dot3Ati = 0x8966,
        Dot4Ati = 0x8967,
        MadAti = 0x8968,
        LerpAti = 0x8969,
        CndAti = 0x896A,
        Cnd0Ati = 0x896B,
        Dot2AddAti = 0x896C,
    }

    public enum GlFramebufferStatus : uint {
        FramebufferComplete = 0x8CD5,
        FramebufferUndefined = 0x8219,
        FramebufferIncompleteAttachment = 0x8CD6,
        FramebufferIncompleteMissingAttachment = 0x8CD7,
        FramebufferIncompleteDrawBuffer = 0x8CDB,
        FramebufferIncompleteReadBuffer = 0x8CDC,
        FramebufferUnsupported = 0x8CDD,
        FramebufferIncompleteMultisample = 0x8D56,
        FramebufferIncompleteLayerTargets = 0x8DA8,
    }

    public enum GlGraphicsResetStatus : uint {
        NoError = 0,
        GuiltyContextReset = 0x8253,
        InnocentContextReset = 0x8254,
        UnknownContextReset = 0x8255,
    }

    public enum GlSyncStatus : uint {
        AlreadySignaled = 0x911A,
        TimeoutExpired = 0x911B,
        ConditionSatisfied = 0x911C,
        WaitFailed = 0x911D,
    }

    public enum GlQueryTarget : uint {
        SamplesPassed = 0x8914,
        AnySamplesPassed = 0x8C2F,
        AnySamplesPassedConservative = 0x8D6A,
        PrimitivesGenerated = 0x8C87,
        TransformFeedbackPrimitivesWritten = 0x8C88,
        TimeElapsed = 0x88BF,
    }

    public enum GlConvolutionTarget : uint {
        Convolution1d = 0x8010,
        Convolution2d = 0x8011,
    }

    public enum GlPathFillMode : uint {
        Invert = 0x150A,
        CountUpNv = 0x9088,
        CountDownNv = 0x9089,
        PathFillModeNv = 0x9080,
    }

    public enum GlColorTableTarget : uint {
        ColorTable = 0x80D0,
        PostConvolutionColorTable = 0x80D1,
        PostColorMatrixColorTable = 0x80D2,
    }

    public enum GlVertexBufferObjectParameter : uint {
        BufferAccess = 0x88BB,
        BufferAccessFlags = 0x911F,
        BufferImmutableStorage = 0x821F,
        BufferMapped = 0x88BC,
        BufferMapLength = 0x9120,
        BufferMapOffset = 0x9121,
        BufferSize = 0x8764,
        BufferStorageFlags = 0x8220,
        BufferUsage = 0x8765,
    }

    public enum GlRenderbufferParameterName : uint {
        RenderbufferWidth = 0x8D42,
        RenderbufferHeight = 0x8D43,
        RenderbufferInternalFormat = 0x8D44,
        RenderbufferSamples = 0x8CAB,
        RenderbufferRedSize = 0x8D50,
        RenderbufferGreenSize = 0x8D51,
        RenderbufferBlueSize = 0x8D52,
        RenderbufferAlphaSize = 0x8D53,
        RenderbufferDepthSize = 0x8D54,
        RenderbufferStencilSize = 0x8D55,
    }

    public enum GlVertexBufferObjectUsage : uint {
        StreamDraw = 0x88E0,
        StreamRead = 0x88E1,
        StreamCopy = 0x88E2,
        StaticDraw = 0x88E4,
        StaticRead = 0x88E5,
        StaticCopy = 0x88E6,
        DynamicDraw = 0x88E8,
        DynamicRead = 0x88E9,
        DynamicCopy = 0x88EA,
    }

    public enum GlFramebufferParameterName : uint {
        FramebufferDefaultWidth = 0x9310,
        FramebufferDefaultHeight = 0x9311,
        FramebufferDefaultLayers = 0x9312,
        FramebufferDefaultSamples = 0x9313,
        FramebufferDefaultFixedSampleLocations = 0x9314,
    }

    public enum GlProgramParameterPName : uint {
        ProgramBinaryRetrievableHint = 0x8257,
        ProgramSeparable = 0x8258,
    }

    public enum GlBlendingFactor : uint {
        Zero = 0,
        One = 1,
        SrcColor = 0x0300,
        OneMinusSrcColor = 0x0301,
        DstColor = 0x0306,
        OneMinusDstColor = 0x0307,
        SrcAlpha = 0x0302,
        OneMinusSrcAlpha = 0x0303,
        DstAlpha = 0x0304,
        OneMinusDstAlpha = 0x0305,
        ConstantColor = 0x8001,
        OneMinusConstantColor = 0x8002,
        ConstantAlpha = 0x8003,
        OneMinusConstantAlpha = 0x8004,
        SrcAlphaSaturate = 0x0308,
        Src1Color = 0x88F9,
        Src1Alpha = 0x8589,
    }

    public enum GlBindTransformFeedbackTarget : uint {
        TransformFeedback = 0x8E22,
    }

    public enum GlBlitFramebufferFilter : uint {
        Nearest = 0x2600,
        Linear = 0x2601,
    }

    public enum GlBufferStorageTarget : uint {
        ArrayBuffer = 0x8892,
        AtomicCounterBuffer = 0x92C0,
        CopyReadBuffer = 0x8F36,
        CopyWriteBuffer = 0x8F37,
        DispatchIndirectBuffer = 0x90EE,
        DrawIndirectBuffer = 0x8F3F,
        ElementArrayBuffer = 0x8893,
        PixelPackBuffer = 0x88EB,
        PixelUnpackBuffer = 0x88EC,
        QueryBuffer = 0x9192,
        ShaderStorageBuffer = 0x90D2,
        TextureBuffer = 0x8C2A,
        TransformFeedbackBuffer = 0x8C8E,
        UniformBuffer = 0x8A11,
    }

    public enum GlCheckFramebufferStatusTarget : uint {
        DrawFramebuffer = 0x8CA9,
        ReadFramebuffer = 0x8CA8,
        Framebuffer = 0x8D40,
    }

    public enum GlBuffer : uint {
        Color = 0x1800,
        Depth = 0x1801,
        Stencil = 0x1802,
    }

    public enum GlClipControlOrigin : uint {
        LowerLeft = 0x8CA1,
        UpperLeft = 0x8CA2,
    }

    public enum GlClipControlDepth : uint {
        NegativeOneToOne = 0x935E,
        ZeroToOne = 0x935F,
    }

    public enum GlCopyBufferSubDataTarget : uint {
        ArrayBuffer = 0x8892,
        AtomicCounterBuffer = 0x92C0,
        CopyReadBuffer = 0x8F36,
        CopyWriteBuffer = 0x8F37,
        DispatchIndirectBuffer = 0x90EE,
        DrawIndirectBuffer = 0x8F3F,
        ElementArrayBuffer = 0x8893,
        PixelPackBuffer = 0x88EB,
        PixelUnpackBuffer = 0x88EC,
        QueryBuffer = 0x9192,
        ShaderStorageBuffer = 0x90D2,
        TextureBuffer = 0x8C2A,
        TransformFeedbackBuffer = 0x8C8E,
        UniformBuffer = 0x8A11,
    }

    public enum GlShaderType : uint {
        ComputeShader = 0x91B9,
        VertexShader = 0x8B31,
        TessControlShader = 0x8E88,
        TessEvaluationShader = 0x8E87,
        GeometryShader = 0x8DD9,
        FragmentShader = 0x8B30,
        FragmentShaderArb = 0x8B30,
        VertexShaderArb = 0x8B31,
    }

    public enum GlDebugSource : uint {
        DebugSourceApi = 0x8246,
        DebugSourceWindowSystem = 0x8247,
        DebugSourceShaderCompiler = 0x8248,
        DebugSourceThirdParty = 0x8249,
        DebugSourceApplication = 0x824A,
        DebugSourceOther = 0x824B,
        DontCare = 0x1100,
    }

    public enum GlDebugType : uint {
        DebugTypeError = 0x824C,
        DebugTypeDeprecatedBehavior = 0x824D,
        DebugTypeUndefinedBehavior = 0x824E,
        DebugTypePortability = 0x824F,
        DebugTypePerformance = 0x8250,
        DebugTypeMarker = 0x8268,
        DebugTypePushGroup = 0x8269,
        DebugTypePopGroup = 0x826A,
        DebugTypeOther = 0x8251,
        DontCare = 0x1100,
    }

    public enum GlDebugSeverity : uint {
        DebugSeverityLow = 0x9148,
        DebugSeverityMedium = 0x9147,
        DebugSeverityHigh = 0x9146,
        DontCare = 0x1100,
    }

    public enum GlSyncCondition : uint {
        SyncGpuCommandsComplete = 0x9117,
    }

    public enum GlFogPName : uint {
        FogMode = 0x0B65,
        FogDensity = 0x0B62,
        FogStart = 0x0B63,
        FogEnd = 0x0B64,
        FogIndex = 0x0B61,
        FogCoordSrc = 0x8450,
    }

    public enum GlAtomicCounterBufferPName : uint {
        AtomicCounterBufferBinding = 0x92C1,
        AtomicCounterBufferDataSize = 0x92C4,
        AtomicCounterBufferActiveAtomicCounters = 0x92C5,
        AtomicCounterBufferActiveAtomicCounterIndices = 0x92C6,
        AtomicCounterBufferReferencedByVertexShader = 0x92C7,
        AtomicCounterBufferReferencedByTessControlShader = 0x92C8,
        AtomicCounterBufferReferencedByTessEvaluationShader = 0x92C9,
        AtomicCounterBufferReferencedByGeometryShader = 0x92CA,
        AtomicCounterBufferReferencedByFragmentShader = 0x92CB,
        AtomicCounterBufferReferencedByComputeShader = 0x90ED,
    }

    public enum GlUniformBlockPName : uint {
        UniformBlockBinding = 0x8A3F,
        UniformBlockDataSize = 0x8A40,
        UniformBlockNameLength = 0x8A41,
        UniformBlockActiveUniforms = 0x8A42,
        UniformBlockActiveUniformIndices = 0x8A43,
        UniformBlockReferencedByVertexShader = 0x8A44,
        UniformBlockReferencedByTessControlShader = 0x84F0,
        UniformBlockReferencedByTessEvaluationShader = 0x84F1,
        UniformBlockReferencedByGeometryShader = 0x8A45,
        UniformBlockReferencedByFragmentShader = 0x8A46,
        UniformBlockReferencedByComputeShader = 0x90EC,
    }

    public enum GlUniformPName : uint {
        UniformType = 0x8A37,
        UniformSize = 0x8A38,
        UniformNameLength = 0x8A39,
        UniformBlockIndex = 0x8A3A,
        UniformOffset = 0x8A3B,
        UniformArrayStride = 0x8A3C,
        UniformMatrixStride = 0x8A3D,
        UniformIsRowMajor = 0x8A3E,
        UniformAtomicCounterBufferIndex = 0x92DA,
    }

    public enum GlSamplerParameterName : uint {
        TextureWrapS = 0x2802,
        TextureWrapT = 0x2803,
        TextureWrapR = 0x8072,
        TextureMinFilter = 0x2801,
        TextureMagFilter = 0x2800,
        TextureBorderColor = 0x1004,
        TextureMinLod = 0x813A,
        TextureMaxLod = 0x813B,
        TextureCompareMode = 0x884C,
        TextureCompareFunc = 0x884D,
    }

    public enum GlVertexProvokingMode : uint {
        FirstVertexConvention = 0x8E4D,
        LastVertexConvention = 0x8E4E,
    }

    public enum GlPatchParameterName : uint {
        PatchVertices = 0x8E72,
        PatchDefaultOuterLevel = 0x8E74,
        PatchDefaultInnerLevel = 0x8E73,
    }

    public enum GlObjectIdentifier : uint {
        Buffer = 0x82E0,
        Shader = 0x82E1,
        Program = 0x82E2,
        VertexArray = 0x8074,
        Query = 0x82E3,
        ProgramPipeline = 0x82E4,
        TransformFeedback = 0x8E22,
        Sampler = 0x82E6,
        Texture = 0x1702,
        Renderbuffer = 0x8D41,
        Framebuffer = 0x8D40,
    }

    public enum GlColorBuffer : uint {
        None = 0,
        FrontLeft = 0x0400,
        FrontRight = 0x0401,
        BackLeft = 0x0402,
        BackRight = 0x0403,
        Front = 0x0404,
        Back = 0x0405,
        Left = 0x0406,
        Right = 0x0407,
        FrontAndBack = 0x0408,
        ColorAttachment0 = 0x8CE0,
        ColorAttachment1 = 0x8CE1,
        ColorAttachment2 = 0x8CE2,
        ColorAttachment3 = 0x8CE3,
        ColorAttachment4 = 0x8CE4,
        ColorAttachment5 = 0x8CE5,
        ColorAttachment6 = 0x8CE6,
        ColorAttachment7 = 0x8CE7,
        ColorAttachment8 = 0x8CE8,
        ColorAttachment9 = 0x8CE9,
        ColorAttachment10 = 0x8CEA,
        ColorAttachment11 = 0x8CEB,
        ColorAttachment12 = 0x8CEC,
        ColorAttachment13 = 0x8CED,
        ColorAttachment14 = 0x8CEE,
        ColorAttachment15 = 0x8CEF,
        ColorAttachment16 = 0x8CF0,
        ColorAttachment17 = 0x8CF1,
        ColorAttachment18 = 0x8CF2,
        ColorAttachment19 = 0x8CF3,
        ColorAttachment20 = 0x8CF4,
        ColorAttachment21 = 0x8CF5,
        ColorAttachment22 = 0x8CF6,
        ColorAttachment23 = 0x8CF7,
        ColorAttachment24 = 0x8CF8,
        ColorAttachment25 = 0x8CF9,
        ColorAttachment26 = 0x8CFA,
        ColorAttachment27 = 0x8CFB,
        ColorAttachment28 = 0x8CFC,
        ColorAttachment29 = 0x8CFD,
        ColorAttachment30 = 0x8CFE,
        ColorAttachment31 = 0x8CFF,
    }

    public enum GlMapQuery : uint {
        Coeff = 0x0A00,
        Order = 0x0A01,
        Domain = 0x0A02,
    }

    public enum GlVertexArrayPName : uint {
        VertexAttribArrayEnabled = 0x8622,
        VertexAttribArraySize = 0x8623,
        VertexAttribArrayStride = 0x8624,
        VertexAttribArrayType = 0x8625,
        VertexAttribArrayNormalized = 0x886A,
        VertexAttribArrayInteger = 0x88FD,
        VertexAttribArrayLong = 0x874E,
        VertexAttribArrayDivisor = 0x88FE,
        VertexAttribRelativeOffset = 0x82D5,
    }

    public enum GlTransformFeedbackPName : uint {
        TransformFeedbackBufferBinding = 0x8C8F,
        TransformFeedbackBufferStart = 0x8C84,
        TransformFeedbackBufferSize = 0x8C85,
        TransformFeedbackPaused = 0x8E23,
        TransformFeedbackActive = 0x8E24,
    }

    public enum GlSyncParameterName : uint {
        ObjectType = 0x9112,
        SyncStatus = 0x9114,
        SyncCondition = 0x9113,
        SyncFlags = 0x9115,
    }

    public enum GlShaderParameterName : uint {
        ShaderType = 0x8B4F,
        DeleteStatus = 0x8B80,
        CompileStatus = 0x8B81,
        InfoLogLength = 0x8B84,
        ShaderSourceLength = 0x8B88,
    }

    public enum GlQueryObjectParameterName : uint {
        QueryResultAvailable = 0x8867,
        QueryResult = 0x8866,
        QueryResultNoWait = 0x9194,
        QueryTarget = 0x82EA,
    }

    public enum GlQueryParameterName : uint {
        CurrentQuery = 0x8865,
        QueryCounterBits = 0x8864,
    }

    public enum GlProgramStagePName : uint {
        ActiveSubroutineUniforms = 0x8DE6,
        ActiveSubroutineUniformLocations = 0x8E47,
        ActiveSubroutines = 0x8DE5,
        ActiveSubroutineUniformMaxLength = 0x8E49,
        ActiveSubroutineMaxLength = 0x8E48,
    }

    public enum GlPipelineParameterName : uint {
        ActiveProgram = 0x8259,
        VertexShader = 0x8B31,
        TessControlShader = 0x8E88,
        TessEvaluationShader = 0x8E87,
        GeometryShader = 0x8DD9,
        FragmentShader = 0x8B30,
        InfoLogLength = 0x8B84,
    }

    public enum GlProgramInterface : uint {
        Uniform = 0x92E1,
        UniformBlock = 0x92E2,
        ProgramInput = 0x92E3,
        ProgramOutput = 0x92E4,
        VertexSubroutine = 0x92E8,
        TessControlSubroutine = 0x92E9,
        TessEvaluationSubroutine = 0x92EA,
        GeometrySubroutine = 0x92EB,
        FragmentSubroutine = 0x92EC,
        ComputeSubroutine = 0x92ED,
        VertexSubroutineUniform = 0x92EE,
        TessControlSubroutineUniform = 0x92EF,
        TessEvaluationSubroutineUniform = 0x92F0,
        GeometrySubroutineUniform = 0x92F1,
        FragmentSubroutineUniform = 0x92F2,
        ComputeSubroutineUniform = 0x92F3,
        TransformFeedbackVarying = 0x92F4,
        TransformFeedbackBuffer = 0x8C8E,
        BufferVariable = 0x92E5,
        ShaderStorageBlock = 0x92E6,
    }

    public enum GlVertexAttribEnum : uint {
        VertexAttribArrayBufferBinding = 0x889F,
        VertexAttribArrayEnabled = 0x8622,
        VertexAttribArraySize = 0x8623,
        VertexAttribArrayStride = 0x8624,
        VertexAttribArrayType = 0x8625,
        VertexAttribArrayNormalized = 0x886A,
        VertexAttribArrayInteger = 0x88FD,
        VertexAttribArrayDivisor = 0x88FE,
        CurrentVertexAttrib = 0x8626,
    }

    public enum GlVertexAttribType : uint {
        Byte = 0x1400,
        Short = 0x1402,
        Int = 0x1404,
        Fixed = 0x140C,
        Float = 0x1406,
        HalfFloat = 0x140B,
        Double = 0x140A,
        UnsignedByte = 0x1401,
        UnsignedShort = 0x1403,
        UnsignedInt = 0x1405,
        Int2101010Rev = 0x8D9F,
        UnsignedInt2101010Rev = 0x8368,
        UnsignedInt10f11f11fRev = 0x8C3B,
    }

    public enum GlAttributeType : uint {
        FloatVec2 = 0x8B50,
        FloatVec2Arb = 0x8B50,
        FloatVec3 = 0x8B51,
        FloatVec3Arb = 0x8B51,
        FloatVec4 = 0x8B52,
        FloatVec4Arb = 0x8B52,
        IntVec2 = 0x8B53,
        IntVec2Arb = 0x8B53,
        IntVec3 = 0x8B54,
        IntVec3Arb = 0x8B54,
        IntVec4 = 0x8B55,
        IntVec4Arb = 0x8B55,
        Bool = 0x8B56,
        BoolArb = 0x8B56,
        BoolVec2 = 0x8B57,
        BoolVec2Arb = 0x8B57,
        BoolVec3 = 0x8B58,
        BoolVec3Arb = 0x8B58,
        BoolVec4 = 0x8B59,
        BoolVec4Arb = 0x8B59,
        FloatMat2 = 0x8B5A,
        FloatMat2Arb = 0x8B5A,
        FloatMat3 = 0x8B5B,
        FloatMat3Arb = 0x8B5B,
        FloatMat4 = 0x8B5C,
        FloatMat4Arb = 0x8B5C,
        Sampler1d = 0x8B5D,
        Sampler1dArb = 0x8B5D,
        Sampler2d = 0x8B5E,
        Sampler2dArb = 0x8B5E,
        Sampler3d = 0x8B5F,
        Sampler3dArb = 0x8B5F,
        Sampler3dOes = 0x8B5F,
        SamplerCube = 0x8B60,
        SamplerCubeArb = 0x8B60,
        Sampler1dShadow = 0x8B61,
        Sampler1dShadowArb = 0x8B61,
        Sampler2dShadow = 0x8B62,
        Sampler2dShadowArb = 0x8B62,
        Sampler2dShadowExt = 0x8B62,
        Sampler2dRect = 0x8B63,
        Sampler2dRectArb = 0x8B63,
        Sampler2dRectShadow = 0x8B64,
        Sampler2dRectShadowArb = 0x8B64,
        FloatMat2x3 = 0x8B65,
        FloatMat2x3Nv = 0x8B65,
        FloatMat2x4 = 0x8B66,
        FloatMat2x4Nv = 0x8B66,
        FloatMat3x2 = 0x8B67,
        FloatMat3x2Nv = 0x8B67,
        FloatMat3x4 = 0x8B68,
        FloatMat3x4Nv = 0x8B68,
        FloatMat4x2 = 0x8B69,
        FloatMat4x2Nv = 0x8B69,
        FloatMat4x3 = 0x8B6A,
        FloatMat4x3Nv = 0x8B6A,
    }

    public enum GlInternalFormatPName : uint {
        NumSampleCounts = 0x9380,
        Samples = 0x80A9,
        InternalformatSupported = 0x826F,
        InternalformatPreferred = 0x8270,
        InternalformatRedSize = 0x8271,
        InternalformatGreenSize = 0x8272,
        InternalformatBlueSize = 0x8273,
        InternalformatAlphaSize = 0x8274,
        InternalformatDepthSize = 0x8275,
        InternalformatStencilSize = 0x8276,
        InternalformatSharedSize = 0x8277,
        InternalformatRedType = 0x8278,
        InternalformatGreenType = 0x8279,
        InternalformatBlueType = 0x827A,
        InternalformatAlphaType = 0x827B,
        InternalformatDepthType = 0x827C,
        InternalformatStencilType = 0x827D,
        MaxWidth = 0x827E,
        MaxHeight = 0x827F,
        MaxDepth = 0x8280,
        MaxLayers = 0x8281,
        ColorComponents = 0x8283,
        ColorRenderable = 0x8286,
        DepthRenderable = 0x8287,
        StencilRenderable = 0x8288,
        FramebufferRenderable = 0x8289,
        FramebufferRenderableLayered = 0x828A,
        FramebufferBlend = 0x828B,
        ReadPixels = 0x828C,
        ReadPixelsFormat = 0x828D,
        ReadPixelsType = 0x828E,
        TextureImageFormat = 0x828F,
        TextureImageType = 0x8290,
        GetTextureImageFormat = 0x8291,
        GetTextureImageType = 0x8292,
        Mipmap = 0x8293,
        GenerateMipmap = 0x8191,
        AutoGenerateMipmap = 0x8295,
        ColorEncoding = 0x8296,
        SrgbRead = 0x8297,
        SrgbWrite = 0x8298,
        Filter = 0x829A,
        VertexTexture = 0x829B,
        TessControlTexture = 0x829C,
        TessEvaluationTexture = 0x829D,
        GeometryTexture = 0x829E,
        FragmentTexture = 0x829F,
        ComputeTexture = 0x82A0,
        TextureShadow = 0x82A1,
        TextureGather = 0x82A2,
        TextureGatherShadow = 0x82A3,
        ShaderImageLoad = 0x82A4,
        ShaderImageStore = 0x82A5,
        ShaderImageAtomic = 0x82A6,
        ImageTexelSize = 0x82A7,
        ImageCompatibilityClass = 0x82A8,
        ImagePixelFormat = 0x82A9,
        ImagePixelType = 0x82AA,
        ImageFormatCompatibilityType = 0x90C7,
        SimultaneousTextureAndDepthTest = 0x82AC,
        SimultaneousTextureAndStencilTest = 0x82AD,
        SimultaneousTextureAndDepthWrite = 0x82AE,
        SimultaneousTextureAndStencilWrite = 0x82AF,
        TextureCompressed = 0x86A1,
        TextureCompressedBlockWidth = 0x82B1,
        TextureCompressedBlockHeight = 0x82B2,
        TextureCompressedBlockSize = 0x82B3,
        ClearBuffer = 0x82B4,
        TextureView = 0x82B5,
        ViewCompatibilityClass = 0x82B6,
        ClearTexture = 0x9365,
    }

    public enum GlFramebufferAttachmentParameterName : uint {
        FramebufferAttachmentRedSize = 0x8212,
        FramebufferAttachmentGreenSize = 0x8213,
        FramebufferAttachmentBlueSize = 0x8214,
        FramebufferAttachmentAlphaSize = 0x8215,
        FramebufferAttachmentDepthSize = 0x8216,
        FramebufferAttachmentStencilSize = 0x8217,
        FramebufferAttachmentComponentType = 0x8211,
        FramebufferAttachmentColorEncoding = 0x8210,
        FramebufferAttachmentObjectName = 0x8CD1,
        FramebufferAttachmentTextureLevel = 0x8CD2,
        FramebufferAttachmentTextureCubeMapFace = 0x8CD3,
        FramebufferAttachmentLayered = 0x8DA7,
        FramebufferAttachmentTextureLayer = 0x8CD4,
    }

    public enum GlProgramInterfacePName : uint {
        ActiveResources = 0x92F5,
        MaxNameLength = 0x92F6,
        MaxNumActiveVariables = 0x92F7,
        MaxNumCompatibleSubroutines = 0x92F8,
    }

    public enum GlPrecisionType : uint {
        LowFloat = 0x8DF0,
        MediumFloat = 0x8DF1,
        HighFloat = 0x8DF2,
        LowInt = 0x8DF3,
        MediumInt = 0x8DF4,
        HighInt = 0x8DF5,
    }

    public enum GlVertexAttribPointerType : uint {
        Byte = 0x1400,
        UnsignedByte = 0x1401,
        Short = 0x1402,
        UnsignedShort = 0x1403,
        Int = 0x1404,
        UnsignedInt = 0x1405,
        Float = 0x1406,
        Double = 0x140A,
        HalfFloat = 0x140B,
        Fixed = 0x140C,
        Int2101010Rev = 0x8D9F,
        UnsignedInt2101010Rev = 0x8368,
        UnsignedInt10f11f11fRev = 0x8C3B,
    }

    public enum GlSubroutineParameterName : uint {
        NumCompatibleSubroutines = 0x8E4A,
        CompatibleSubroutines = 0x8E4B,
        UniformSize = 0x8A38,
        UniformNameLength = 0x8A39,
    }

    public enum GlGetFramebufferParameter : uint {
        FramebufferDefaultWidth = 0x9310,
        FramebufferDefaultHeight = 0x9311,
        FramebufferDefaultLayers = 0x9312,
        FramebufferDefaultSamples = 0x9313,
        FramebufferDefaultFixedSampleLocations = 0x9314,
        Doublebuffer = 0x0C32,
        ImplementationColorReadFormat = 0x8B9B,
        ImplementationColorReadType = 0x8B9A,
        Samples = 0x80A9,
        SampleBuffers = 0x80A8,
        Stereo = 0x0C33,
    }

    public enum GlPathStringFormat : uint {
        PathFormatSvgNv = 0x9070,
        PathFormatPsNv = 0x9071,
    }

    public enum GlPathFontTarget : uint {
        StandardFontNameNv = 0x9072,
        SystemFontNameNv = 0x9073,
        FileNameNv = 0x9074,
    }

    public enum GlPathHandleMissingGlyphs : uint {
        SkipMissingGlyphNv = 0x90A9,
        UseMissingGlyphNv = 0x90AA,
    }

    public enum GlPathParameter : uint {
        PathStrokeWidthNv = 0x9075,
        PathInitialEndCapNv = 0x9077,
        PathTerminalEndCapNv = 0x9078,
        PathJoinStyleNv = 0x9079,
        PathMiterLimitNv = 0x907A,
        PathInitialDashCapNv = 0x907C,
        PathTerminalDashCapNv = 0x907D,
        PathDashOffsetNv = 0x907E,
        PathClientLengthNv = 0x907F,
        PathDashOffsetResetNv = 0x90B4,
        PathFillModeNv = 0x9080,
        PathFillMaskNv = 0x9081,
        PathFillCoverModeNv = 0x9082,
        PathStrokeCoverModeNv = 0x9083,
        PathStrokeMaskNv = 0x9084,
        PathEndCapsNv = 0x9076,
        PathDashCapsNv = 0x907B,
        PathCommandCountNv = 0x909D,
        PathCoordCountNv = 0x909E,
        PathDashArrayCountNv = 0x909F,
        PathComputedLengthNv = 0x90A0,
        PathObjectBoundingBoxNv = 0x908A,
        PathFillBoundingBoxNv = 0x90A1,
        PathStrokeBoundingBoxNv = 0x90A2,
    }

    public enum GlPathColor : uint {
        PrimaryColor = 0x8577,
        PrimaryColorNv = 0x852C,
        SecondaryColorNv = 0x852D,
    }

    public enum GlPathGenMode : uint {
        None = 0,
        EyeLinear = 0x2400,
        ObjectLinear = 0x2401,
        PathObjectBoundingBoxNv = 0x908A,
        Constant = 0x8576,
    }

    public enum GlTextureLayout : uint {
        LayoutGeneralExt = 0x958D,
        LayoutColorAttachmentExt = 0x958E,
        LayoutDepthStencilAttachmentExt = 0x958F,
        LayoutDepthStencilReadOnlyExt = 0x9590,
        LayoutShaderReadOnlyExt = 0x9591,
        LayoutTransferSrcExt = 0x9592,
        LayoutTransferDstExt = 0x9593,
        LayoutDepthReadOnlyStencilAttachmentExt = 0x9530,
        LayoutDepthAttachmentStencilReadOnlyExt = 0x9531,
    }

    public enum GlPathTransformType : uint {
        None = 0,
        TranslateXNv = 0x908E,
        TranslateYNv = 0x908F,
        Translate2dNv = 0x9090,
        Translate3dNv = 0x9091,
        Affine2dNv = 0x9092,
        Affine3dNv = 0x9094,
        TransposeAffine2dNv = 0x9096,
        TransposeAffine3dNv = 0x9098,
    }

    public enum GlPathElementType : uint {
        Utf8Nv = 0x909A,
        Utf16Nv = 0x909B,
    }

    public enum GlPathCoverMode : uint {
        ConvexHullNv = 0x908B,
        BoundingBoxNv = 0x908D,
        BoundingBoxOfBoundingBoxesNv = 0x909C,
        PathFillCoverModeNv = 0x9082,
    }

    public enum GlPathFontStyle : uint {
        None = 0,
        BoldBitNv = 0x01,
        ItalicBitNv = 0x02,
    }

    public enum GlPathMetricMask : uint {
        GlyphWidthBitNv = 0x01,
        GlyphHeightBitNv = 0x02,
        GlyphHorizontalBearingXBitNv = 0x04,
        GlyphHorizontalBearingYBitNv = 0x08,
        GlyphHorizontalBearingAdvanceBitNv = 0x10,
        GlyphVerticalBearingXBitNv = 0x20,
        GlyphVerticalBearingYBitNv = 0x40,
        GlyphVerticalBearingAdvanceBitNv = 0x80,
        GlyphHasKerningBitNv = 0x100,
        FontXMinBoundsBitNv = 0x00010000,
        FontYMinBoundsBitNv = 0x00020000,
        FontXMaxBoundsBitNv = 0x00040000,
        FontYMaxBoundsBitNv = 0x00080000,
        FontUnitsPerEmBitNv = 0x00100000,
        FontAscenderBitNv = 0x00200000,
        FontDescenderBitNv = 0x00400000,
        FontHeightBitNv = 0x00800000,
        FontMaxAdvanceWidthBitNv = 0x01000000,
        FontMaxAdvanceHeightBitNv = 0x02000000,
        FontUnderlinePositionBitNv = 0x04000000,
        FontUnderlineThicknessBitNv = 0x08000000,
        FontHasKerningBitNv = 0x10000000,
        FontNumGlyphIndicesBitNv = 0x20000000,
    }

    public enum GlPathListMode : uint {
        AccumAdjacentPairsNv = 0x90AD,
        AdjacentPairsNv = 0x90AE,
        FirstToRestNv = 0x90AF,
    }

    public enum GlProgramPropertyARB : uint {
        DeleteStatus = 0x8B80,
        LinkStatus = 0x8B82,
        ValidateStatus = 0x8B83,
        InfoLogLength = 0x8B84,
        AttachedShaders = 0x8B85,
        ActiveAtomicCounterBuffers = 0x92D9,
        ActiveAttributes = 0x8B89,
        ActiveAttributeMaxLength = 0x8B8A,
        ActiveUniforms = 0x8B86,
        ActiveUniformBlocks = 0x8A36,
        ActiveUniformBlockMaxNameLength = 0x8A35,
        ActiveUniformMaxLength = 0x8B87,
        ComputeWorkGroupSize = 0x8267,
        ProgramBinaryLength = 0x8741,
        TransformFeedbackBufferMode = 0x8C7F,
        TransformFeedbackVaryings = 0x8C83,
        TransformFeedbackVaryingMaxLength = 0x8C76,
        GeometryVerticesOut = 0x8916,
        GeometryInputType = 0x8917,
        GeometryOutputType = 0x8918,
    }

    public interface IOpenGLContext : IRenderContext {
        void Accum(GlAccumOp @op, float @value);
        void AccumxOES(uint @op, int @value);
        void ActiveProgramEXT(uint @program);
        void ActiveShaderProgram(uint @pipeline, uint @program);
        void ActiveShaderProgramEXT(uint @pipeline, uint @program);
        void ActiveStencilFaceEXT(GlStencilFaceDirection @face);
        void ActiveTexture(GlTextureUnit @texture);
        void ActiveTextureARB(GlTextureUnit @texture);
        void ActiveVaryingNV(uint @program, byte[] @name);
        void AlphaFragmentOp1ATI(GlFragmentOpATI @op, uint @dst, uint @dstMod, uint @arg1, uint @arg1Rep, uint @arg1Mod);
        void AlphaFragmentOp2ATI(GlFragmentOpATI @op, uint @dst, uint @dstMod, uint @arg1, uint @arg1Rep, uint @arg1Mod, uint @arg2, uint @arg2Rep, uint @arg2Mod);
        void AlphaFragmentOp3ATI(GlFragmentOpATI @op, uint @dst, uint @dstMod, uint @arg1, uint @arg1Rep, uint @arg1Mod, uint @arg2, uint @arg2Rep, uint @arg2Mod, uint @arg3, uint @arg3Rep, uint @arg3Mod);
        void AlphaFunc(GlAlphaFunction @func, float @ref);
        void AlphaFuncQCOM(uint @func, float @ref);
        void AlphaFuncx(GlAlphaFunction @func, int @ref);
        void AlphaFuncxOES(GlAlphaFunction @func, int @ref);
        void AlphaToCoverageDitherControlNV(uint @mode);
        void ApplyFramebufferAttachmentCMAAINTEL();
        void ApplyTextureEXT(uint @mode);
        bool AcquireKeyedMutexWin32EXT(uint @memory, ulong @key, uint @timeout);
        bool AreProgramsResidentNV(int @n, uint[] @programs, GlBoolean[] @residences);
        bool AreTexturesResident(int @n, uint[] @textures, GlBoolean[] @residences);
        bool AreTexturesResidentEXT(int @n, uint[] @textures, GlBoolean[] @residences);
        void ArrayElement(int @i);
        void ArrayElementEXT(int @i);
        void ArrayObjectATI(GlEnableCap @array, int @size, uint @type, int @stride, uint @buffer, uint @offset);
        void AsyncMarkerSGIX(uint @marker);
        void AttachObjectARB(IntPtr @containerObj, IntPtr @obj);
        void AttachShader(uint @program, uint @shader);
        void Begin(GlPrimitiveType @mode);
        void BeginConditionalRender(uint @id, GlTypeEnum @mode);
        void BeginConditionalRenderNV(uint @id, GlTypeEnum @mode);
        void BeginConditionalRenderNVX(uint @id);
        void BeginFragmentShaderATI();
        void BeginOcclusionQueryNV(uint @id);
        void BeginPerfMonitorAMD(uint @monitor);
        void BeginPerfQueryINTEL(uint @queryHandle);
        void BeginQuery(GlQueryTarget @target, uint @id);
        void BeginQueryARB(uint @target, uint @id);
        void BeginQueryEXT(GlQueryTarget @target, uint @id);
        void BeginQueryIndexed(GlQueryTarget @target, uint @index, uint @id);
        void BeginTransformFeedback(GlPrimitiveType @primitiveMode);
        void BeginTransformFeedbackEXT(GlPrimitiveType @primitiveMode);
        void BeginTransformFeedbackNV(GlPrimitiveType @primitiveMode);
        void BeginVertexShaderEXT();
        void BeginVideoCaptureNV(uint @video_capture_slot);
        void BindAttribLocation(uint @program, uint @index, byte[] @name);
        void BindAttribLocationARB(IntPtr @programObj, uint @index, byte[] @name);
        void BindBuffer(GlBufferTargetARB @target, uint @buffer);
        void BindBufferARB(GlBufferTargetARB @target, uint @buffer);
        void BindBufferBase(GlBufferTargetARB @target, uint @index, uint @buffer);
        void BindBufferBaseEXT(GlBufferTargetARB @target, uint @index, uint @buffer);
        void BindBufferBaseNV(GlBufferTargetARB @target, uint @index, uint @buffer);
        void BindBufferOffsetEXT(GlBufferTargetARB @target, uint @index, uint @buffer, long @offset);
        void BindBufferOffsetNV(GlBufferTargetARB @target, uint @index, uint @buffer, long @offset);
        void BindBufferRange(GlBufferTargetARB @target, uint @index, uint @buffer, long @offset, long @size);
        void BindBufferRangeEXT(GlBufferTargetARB @target, uint @index, uint @buffer, long @offset, long @size);
        void BindBufferRangeNV(GlBufferTargetARB @target, uint @index, uint @buffer, long @offset, long @size);
        void BindBuffersBase(GlBufferTargetARB @target, uint @first, int @count, uint[] @buffers);
        void BindBuffersRange(GlBufferTargetARB @target, uint @first, int @count, uint[] @buffers, long[] @offsets, long[] @sizes);
        void BindFragDataLocation(uint @program, uint @color, byte[] @name);
        void BindFragDataLocationEXT(uint @program, uint @color, byte[] @name);
        void BindFragDataLocationIndexed(uint @program, uint @colorNumber, uint @index, byte[] @name);
        void BindFragDataLocationIndexedEXT(uint @program, uint @colorNumber, uint @index, byte[] @name);
        void BindFragmentShaderATI(uint @id);
        void BindFramebuffer(GlFramebufferTarget @target, uint @framebuffer);
        void BindFramebufferEXT(GlFramebufferTarget @target, uint @framebuffer);
        void BindFramebufferOES(GlFramebufferTarget @target, uint @framebuffer);
        void BindImageTexture(uint @unit, uint @texture, int @level, GlBoolean @layered, int @layer, GlBufferAccessARB @access, GlInternalFormat @format);
        void BindImageTextureEXT(uint @index, uint @texture, int @level, GlBoolean @layered, int @layer, GlBufferAccessARB @access, int @format);
        void BindImageTextures(uint @first, int @count, uint[] @textures);
        uint BindLightParameterEXT(GlLightName @light, GlLightParameter @value);
        uint BindMaterialParameterEXT(GlMaterialFace @face, GlMaterialParameter @value);
        void BindMultiTextureEXT(GlTextureUnit @texunit, GlTextureTarget @target, uint @texture);
        uint BindParameterEXT(uint @value);
        void BindProgramARB(uint @target, uint @program);
        void BindProgramNV(uint @target, uint @id);
        void BindProgramPipeline(uint @pipeline);
        void BindProgramPipelineEXT(uint @pipeline);
        void BindRenderbuffer(GlRenderbufferTarget @target, uint @renderbuffer);
        void BindRenderbufferEXT(GlRenderbufferTarget @target, uint @renderbuffer);
        void BindRenderbufferOES(GlRenderbufferTarget @target, uint @renderbuffer);
        void BindSampler(uint @unit, uint @sampler);
        void BindSamplers(uint @first, int @count, uint[] @samplers);
        uint BindTexGenParameterEXT(GlTextureUnit @unit, GlTextureCoordName @coord, GlTextureGenParameter @value);
        void BindTexture(GlTextureTarget @target, uint @texture);
        void BindTextureEXT(GlTextureTarget @target, uint @texture);
        void BindTextureUnit(uint @unit, uint @texture);
        uint BindTextureUnitParameterEXT(GlTextureUnit @unit, uint @value);
        void BindTextures(uint @first, int @count, uint[] @textures);
        void BindTransformFeedback(GlBindTransformFeedbackTarget @target, uint @id);
        void BindTransformFeedbackNV(GlBufferTargetARB @target, uint @id);
        void BindVertexArray(uint @array);
        void BindVertexArrayAPPLE(uint @array);
        void BindVertexArrayOES(uint @array);
        void BindVertexBuffer(uint @bindingindex, uint @buffer, long @offset, int @stride);
        void BindVertexBuffers(uint @first, int @count, uint[] @buffers, long[] @offsets, int[] @strides);
        void BindVertexShaderEXT(uint @id);
        void BindVideoCaptureStreamBufferNV(uint @video_capture_slot, uint @stream, uint @frame_region, long @offset);
        void BindVideoCaptureStreamTextureNV(uint @video_capture_slot, uint @stream, uint @frame_region, uint @target, uint @texture);
        void Binormal3bEXT(sbyte @bx, sbyte @by, sbyte @bz);
        void Binormal3bvEXT(sbyte[] @v);
        void Binormal3dEXT(double @bx, double @by, double @bz);
        void Binormal3dvEXT(double[] @v);
        void Binormal3fEXT(float @bx, float @by, float @bz);
        void Binormal3fvEXT(float[] @v);
        void Binormal3iEXT(int @bx, int @by, int @bz);
        void Binormal3ivEXT(int[] @v);
        void Binormal3sEXT(short @bx, short @by, short @bz);
        void Binormal3svEXT(short[] @v);
        void BinormalPointerEXT(uint @type, int @stride, byte[] @pointer);
        void Bitmap(int @width, int @height, float @xorig, float @yorig, float @xmove, float @ymove, byte[] @bitmap);
        void BitmapxOES(int @width, int @height, int @xorig, int @yorig, int @xmove, int @ymove, byte[] @bitmap);
        void BlendBarrier();
        void BlendBarrierKHR();
        void BlendBarrierNV();
        void BlendColor(float @red, float @green, float @blue, float @alpha);
        void BlendColorEXT(float @red, float @green, float @blue, float @alpha);
        void BlendColorxOES(int @red, int @green, int @blue, int @alpha);
        void BlendEquation(GlBlendEquationModeEXT @mode);
        void BlendEquationEXT(GlBlendEquationModeEXT @mode);
        void BlendEquationIndexedAMD(uint @buf, GlBlendEquationModeEXT @mode);
        void BlendEquationOES(GlBlendEquationModeEXT @mode);
        void BlendEquationSeparate(GlBlendEquationModeEXT @modeRGB, GlBlendEquationModeEXT @modeAlpha);
        void BlendEquationSeparateEXT(GlBlendEquationModeEXT @modeRGB, GlBlendEquationModeEXT @modeAlpha);
        void BlendEquationSeparateIndexedAMD(uint @buf, GlBlendEquationModeEXT @modeRGB, GlBlendEquationModeEXT @modeAlpha);
        void BlendEquationSeparateOES(GlBlendEquationModeEXT @modeRGB, GlBlendEquationModeEXT @modeAlpha);
        void BlendEquationSeparatei(uint @buf, GlBlendEquationModeEXT @modeRGB, GlBlendEquationModeEXT @modeAlpha);
        void BlendEquationSeparateiARB(uint @buf, GlBlendEquationModeEXT @modeRGB, GlBlendEquationModeEXT @modeAlpha);
        void BlendEquationSeparateiEXT(uint @buf, GlBlendEquationModeEXT @modeRGB, GlBlendEquationModeEXT @modeAlpha);
        void BlendEquationSeparateiOES(uint @buf, GlBlendEquationModeEXT @modeRGB, GlBlendEquationModeEXT @modeAlpha);
        void BlendEquationi(uint @buf, GlBlendEquationModeEXT @mode);
        void BlendEquationiARB(uint @buf, GlBlendEquationModeEXT @mode);
        void BlendEquationiEXT(uint @buf, GlBlendEquationModeEXT @mode);
        void BlendEquationiOES(uint @buf, GlBlendEquationModeEXT @mode);
        void BlendFunc(GlBlendingFactor @sfactor, GlBlendingFactor @dfactor);
        void BlendFuncIndexedAMD(uint @buf, uint @src, uint @dst);
        void BlendFuncSeparate(GlBlendingFactor @sfactorRGB, GlBlendingFactor @dfactorRGB, GlBlendingFactor @sfactorAlpha, GlBlendingFactor @dfactorAlpha);
        void BlendFuncSeparateEXT(GlBlendingFactor @sfactorRGB, GlBlendingFactor @dfactorRGB, GlBlendingFactor @sfactorAlpha, GlBlendingFactor @dfactorAlpha);
        void BlendFuncSeparateINGR(GlBlendingFactor @sfactorRGB, GlBlendingFactor @dfactorRGB, GlBlendingFactor @sfactorAlpha, GlBlendingFactor @dfactorAlpha);
        void BlendFuncSeparateIndexedAMD(uint @buf, GlBlendingFactor @srcRGB, GlBlendingFactor @dstRGB, GlBlendingFactor @srcAlpha, GlBlendingFactor @dstAlpha);
        void BlendFuncSeparateOES(GlBlendingFactor @srcRGB, GlBlendingFactor @dstRGB, GlBlendingFactor @srcAlpha, GlBlendingFactor @dstAlpha);
        void BlendFuncSeparatei(uint @buf, GlBlendingFactor @srcRGB, GlBlendingFactor @dstRGB, GlBlendingFactor @srcAlpha, GlBlendingFactor @dstAlpha);
        void BlendFuncSeparateiARB(uint @buf, GlBlendingFactor @srcRGB, GlBlendingFactor @dstRGB, GlBlendingFactor @srcAlpha, GlBlendingFactor @dstAlpha);
        void BlendFuncSeparateiEXT(uint @buf, GlBlendingFactor @srcRGB, GlBlendingFactor @dstRGB, GlBlendingFactor @srcAlpha, GlBlendingFactor @dstAlpha);
        void BlendFuncSeparateiOES(uint @buf, GlBlendingFactor @srcRGB, GlBlendingFactor @dstRGB, GlBlendingFactor @srcAlpha, GlBlendingFactor @dstAlpha);
        void BlendFunci(uint @buf, GlBlendingFactor @src, GlBlendingFactor @dst);
        void BlendFunciARB(uint @buf, GlBlendingFactor @src, GlBlendingFactor @dst);
        void BlendFunciEXT(uint @buf, GlBlendingFactor @src, GlBlendingFactor @dst);
        void BlendFunciOES(uint @buf, GlBlendingFactor @src, GlBlendingFactor @dst);
        void BlendParameteriNV(uint @pname, int @value);
        void BlitFramebuffer(int @srcX0, int @srcY0, int @srcX1, int @srcY1, int @dstX0, int @dstY0, int @dstX1, int @dstY1, GlClearBufferMask @mask, GlBlitFramebufferFilter @filter);
        void BlitFramebufferANGLE(int @srcX0, int @srcY0, int @srcX1, int @srcY1, int @dstX0, int @dstY0, int @dstX1, int @dstY1, GlClearBufferMask @mask, GlBlitFramebufferFilter @filter);
        void BlitFramebufferEXT(int @srcX0, int @srcY0, int @srcX1, int @srcY1, int @dstX0, int @dstY0, int @dstX1, int @dstY1, GlClearBufferMask @mask, GlBlitFramebufferFilter @filter);
        void BlitFramebufferNV(int @srcX0, int @srcY0, int @srcX1, int @srcY1, int @dstX0, int @dstY0, int @dstX1, int @dstY1, GlClearBufferMask @mask, GlBlitFramebufferFilter @filter);
        void BlitNamedFramebuffer(uint @readFramebuffer, uint @drawFramebuffer, int @srcX0, int @srcY0, int @srcX1, int @srcY1, int @dstX0, int @dstY0, int @dstX1, int @dstY1, GlClearBufferMask @mask, GlBlitFramebufferFilter @filter);
        void BufferAddressRangeNV(uint @pname, uint @index, ulong @address, long @length);
        void BufferData(GlBufferTargetARB @target, long @size, byte[] @data, GlBufferUsageARB @usage);
        void BufferDataARB(GlBufferTargetARB @target, long @size, byte[] @data, GlBufferUsageARB @usage);
        void BufferPageCommitmentARB(uint @target, long @offset, long @size, bool @commit);
        void BufferParameteriAPPLE(uint @target, uint @pname, int @param);
        void BufferStorage(GlBufferStorageTarget @target, long @size, byte[] @data, GlMapBufferUsageMask @flags);
        void BufferStorageEXT(GlBufferStorageTarget @target, long @size, byte[] @data, GlMapBufferUsageMask @flags);
        void BufferStorageExternalEXT(uint @target, long @offset, long @size, byte[] @clientBuffer, GlMapBufferUsageMask @flags);
        void BufferStorageMemEXT(GlBufferTargetARB @target, long @size, uint @memory, ulong @offset);
        void BufferSubData(GlBufferTargetARB @target, long @offset, long @size, byte[] @data);
        void BufferSubDataARB(GlBufferTargetARB @target, long @offset, long @size, byte[] @data);
        void CallCommandListNV(uint @list);
        void CallList(uint @list);
        void CallLists(int @n, GlListNameType @type, byte[] @lists);
        uint CheckFramebufferStatus(GlFramebufferTarget @target);
        uint CheckFramebufferStatusEXT(GlFramebufferTarget @target);
        uint CheckFramebufferStatusOES(GlFramebufferTarget @target);
        uint CheckNamedFramebufferStatus(uint @framebuffer, GlFramebufferTarget @target);
        uint CheckNamedFramebufferStatusEXT(uint @framebuffer, GlFramebufferTarget @target);
        void ClampColor(uint @target, uint @clamp);
        void ClampColorARB(uint @target, uint @clamp);
        void Clear(GlClearBufferMask @mask);
        void ClearAccum(float @red, float @green, float @blue, float @alpha);
        void ClearAccumxOES(int @red, int @green, int @blue, int @alpha);
        void ClearBufferData(GlBufferStorageTarget @target, GlInternalFormat @internalformat, GlPixelFormat @format, GlPixelType @type, byte[] @data);
        void ClearBufferSubData(uint @target, GlInternalFormat @internalformat, long @offset, long @size, GlPixelFormat @format, GlPixelType @type, byte[] @data);
        void ClearBufferfi(GlBuffer @buffer, int @drawbuffer, float @depth, int @stencil);
        void ClearBufferfv(GlBuffer @buffer, int @drawbuffer, float[] @value);
        void ClearBufferiv(GlBuffer @buffer, int @drawbuffer, int[] @value);
        void ClearBufferuiv(GlBuffer @buffer, int @drawbuffer, uint[] @value);
        void ClearColor(float @red, float @green, float @blue, float @alpha);
        void ClearColorIiEXT(int @red, int @green, int @blue, int @alpha);
        void ClearColorIuiEXT(uint @red, uint @green, uint @blue, uint @alpha);
        void ClearColorx(int @red, int @green, int @blue, int @alpha);
        void ClearColorxOES(int @red, int @green, int @blue, int @alpha);
        void ClearDepth(double @depth);
        void ClearDepthdNV(double @depth);
        void ClearDepthf(float @d);
        void ClearDepthfOES(float @depth);
        void ClearDepthx(int @depth);
        void ClearDepthxOES(int @depth);
        void ClearIndex(float @c);
        void ClearNamedBufferData(uint @buffer, GlInternalFormat @internalformat, GlPixelFormat @format, GlPixelType @type, byte[] @data);
        void ClearNamedBufferDataEXT(uint @buffer, GlInternalFormat @internalformat, GlPixelFormat @format, GlPixelType @type, byte[] @data);
        void ClearNamedBufferSubData(uint @buffer, GlInternalFormat @internalformat, long @offset, long @size, GlPixelFormat @format, GlPixelType @type, byte[] @data);
        void ClearNamedBufferSubDataEXT(uint @buffer, uint @internalformat, long @offset, long @size, GlPixelFormat @format, GlPixelType @type, byte[] @data);
        void ClearNamedFramebufferfi(uint @framebuffer, GlBuffer @buffer, int @drawbuffer, float @depth, int @stencil);
        void ClearNamedFramebufferfv(uint @framebuffer, GlBuffer @buffer, int @drawbuffer, float[] @value);
        void ClearNamedFramebufferiv(uint @framebuffer, GlBuffer @buffer, int @drawbuffer, int[] @value);
        void ClearNamedFramebufferuiv(uint @framebuffer, GlBuffer @buffer, int @drawbuffer, uint[] @value);
        void ClearPixelLocalStorageuiEXT(int @offset, int @n, uint[] @values);
        void ClearStencil(int @s);
        void ClearTexImage(uint @texture, int @level, GlPixelFormat @format, GlPixelType @type, byte[] @data);
        void ClearTexImageEXT(uint @texture, int @level, GlPixelFormat @format, GlPixelType @type, byte[] @data);
        void ClearTexSubImage(uint @texture, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, GlPixelFormat @format, GlPixelType @type, byte[] @data);
        void ClearTexSubImageEXT(uint @texture, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, GlPixelFormat @format, GlPixelType @type, byte[] @data);
        void ClientActiveTexture(GlTextureUnit @texture);
        void ClientActiveTextureARB(GlTextureUnit @texture);
        void ClientActiveVertexStreamATI(uint @stream);
        void ClientAttribDefaultEXT(GlClientAttribMask @mask);
        uint ClientWaitSync(IntPtr @sync, GlSyncObjectMask @flags, ulong @timeout);
        uint ClientWaitSyncAPPLE(IntPtr @sync, GlSyncObjectMask @flags, ulong @timeout);
        void ClipControl(GlClipControlOrigin @origin, GlClipControlDepth @depth);
        void ClipControlEXT(uint @origin, uint @depth);
        void ClipPlane(GlClipPlaneName @plane, double[] @equation);
        void ClipPlanef(GlClipPlaneName @p, float[] @eqn);
        void ClipPlanefIMG(GlClipPlaneName @p, float[] @eqn);
        void ClipPlanefOES(GlClipPlaneName @plane, float[] @equation);
        void ClipPlanex(GlClipPlaneName @plane, int[] @equation);
        void ClipPlanexIMG(GlClipPlaneName @p, int[] @eqn);
        void ClipPlanexOES(GlClipPlaneName @plane, int[] @equation);
        void Color3b(sbyte @red, sbyte @green, sbyte @blue);
        void Color3bv(sbyte[] @v);
        void Color3d(double @red, double @green, double @blue);
        void Color3dv(double[] @v);
        void Color3f(float @red, float @green, float @blue);
        void Color3fVertex3fSUN(float @r, float @g, float @b, float @x, float @y, float @z);
        void Color3fVertex3fvSUN(float[] @c, float[] @v);
        void Color3fv(float[] @v);
        void Color3hNV(ushort @red, ushort @green, ushort @blue);
        void Color3hvNV(ushort[] @v);
        void Color3i(int @red, int @green, int @blue);
        void Color3iv(int[] @v);
        void Color3s(short @red, short @green, short @blue);
        void Color3sv(short[] @v);
        void Color3ub(byte @red, byte @green, byte @blue);
        void Color3ubv(byte[] @v);
        void Color3ui(uint @red, uint @green, uint @blue);
        void Color3uiv(uint[] @v);
        void Color3us(ushort @red, ushort @green, ushort @blue);
        void Color3usv(ushort[] @v);
        void Color3xOES(int @red, int @green, int @blue);
        void Color3xvOES(int[] @components);
        void Color4b(sbyte @red, sbyte @green, sbyte @blue, sbyte @alpha);
        void Color4bv(sbyte[] @v);
        void Color4d(double @red, double @green, double @blue, double @alpha);
        void Color4dv(double[] @v);
        void Color4f(float @red, float @green, float @blue, float @alpha);
        void Color4fNormal3fVertex3fSUN(float @r, float @g, float @b, float @a, float @nx, float @ny, float @nz, float @x, float @y, float @z);
        void Color4fNormal3fVertex3fvSUN(float[] @c, float[] @n, float[] @v);
        void Color4fv(float[] @v);
        void Color4hNV(ushort @red, ushort @green, ushort @blue, ushort @alpha);
        void Color4hvNV(ushort[] @v);
        void Color4i(int @red, int @green, int @blue, int @alpha);
        void Color4iv(int[] @v);
        void Color4s(short @red, short @green, short @blue, short @alpha);
        void Color4sv(short[] @v);
        void Color4ub(byte @red, byte @green, byte @blue, byte @alpha);
        void Color4ubVertex2fSUN(byte @r, byte @g, byte @b, byte @a, float @x, float @y);
        void Color4ubVertex2fvSUN(byte[] @c, float[] @v);
        void Color4ubVertex3fSUN(byte @r, byte @g, byte @b, byte @a, float @x, float @y, float @z);
        void Color4ubVertex3fvSUN(byte[] @c, float[] @v);
        void Color4ubv(byte[] @v);
        void Color4ui(uint @red, uint @green, uint @blue, uint @alpha);
        void Color4uiv(uint[] @v);
        void Color4us(ushort @red, ushort @green, ushort @blue, ushort @alpha);
        void Color4usv(ushort[] @v);
        void Color4x(int @red, int @green, int @blue, int @alpha);
        void Color4xOES(int @red, int @green, int @blue, int @alpha);
        void Color4xvOES(int[] @components);
        void ColorFormatNV(int @size, uint @type, int @stride);
        void ColorFragmentOp1ATI(GlFragmentOpATI @op, uint @dst, uint @dstMask, uint @dstMod, uint @arg1, uint @arg1Rep, uint @arg1Mod);
        void ColorFragmentOp2ATI(GlFragmentOpATI @op, uint @dst, uint @dstMask, uint @dstMod, uint @arg1, uint @arg1Rep, uint @arg1Mod, uint @arg2, uint @arg2Rep, uint @arg2Mod);
        void ColorFragmentOp3ATI(GlFragmentOpATI @op, uint @dst, uint @dstMask, uint @dstMod, uint @arg1, uint @arg1Rep, uint @arg1Mod, uint @arg2, uint @arg2Rep, uint @arg2Mod, uint @arg3, uint @arg3Rep, uint @arg3Mod);
        void ColorMask(GlBoolean @red, GlBoolean @green, GlBoolean @blue, GlBoolean @alpha);
        void ColorMaskIndexedEXT(uint @index, GlBoolean @r, GlBoolean @g, GlBoolean @b, GlBoolean @a);
        void ColorMaski(uint @index, GlBoolean @r, GlBoolean @g, GlBoolean @b, GlBoolean @a);
        void ColorMaskiEXT(uint @index, GlBoolean @r, GlBoolean @g, GlBoolean @b, GlBoolean @a);
        void ColorMaskiOES(uint @index, GlBoolean @r, GlBoolean @g, GlBoolean @b, GlBoolean @a);
        void ColorMaterial(GlMaterialFace @face, GlColorMaterialParameter @mode);
        void ColorP3ui(GlColorPointerType @type, uint @color);
        void ColorP3uiv(GlColorPointerType @type, uint[] @color);
        void ColorP4ui(GlColorPointerType @type, uint @color);
        void ColorP4uiv(GlColorPointerType @type, uint[] @color);
        void ColorPointer(int @size, GlColorPointerType @type, int @stride, byte[] @pointer);
        void ColorPointerEXT(int @size, GlColorPointerType @type, int @stride, int @count, byte[] @pointer);
        void ColorPointerListIBM(int @size, GlColorPointerType @type, int @stride, byte[][] @pointer, int @ptrstride);
        void ColorPointervINTEL(int @size, GlVertexPointerType @type, byte[][] @pointer);
        void ColorSubTable(GlColorTableTarget @target, int @start, int @count, GlPixelFormat @format, GlPixelType @type, byte[] @data);
        void ColorSubTableEXT(GlColorTableTarget @target, int @start, int @count, GlPixelFormat @format, GlPixelType @type, byte[] @data);
        void ColorTable(GlColorTableTarget @target, GlInternalFormat @internalformat, int @width, GlPixelFormat @format, GlPixelType @type, byte[] @table);
        void ColorTableEXT(GlColorTableTarget @target, GlInternalFormat @internalFormat, int @width, GlPixelFormat @format, GlPixelType @type, byte[] @table);
        void ColorTableParameterfv(GlColorTableTarget @target, GlColorTableParameterPNameSGI @pname, float[] @params);
        void ColorTableParameterfvSGI(GlColorTableTargetSGI @target, GlColorTableParameterPNameSGI @pname, float[] @params);
        void ColorTableParameteriv(GlColorTableTarget @target, GlColorTableParameterPNameSGI @pname, int[] @params);
        void ColorTableParameterivSGI(GlColorTableTargetSGI @target, GlColorTableParameterPNameSGI @pname, int[] @params);
        void ColorTableSGI(GlColorTableTargetSGI @target, GlInternalFormat @internalformat, int @width, GlPixelFormat @format, GlPixelType @type, byte[] @table);
        void CombinerInputNV(uint @stage, uint @portion, uint @variable, uint @input, uint @mapping, uint @componentUsage);
        void CombinerOutputNV(uint @stage, uint @portion, uint @abOutput, uint @cdOutput, uint @sumOutput, uint @scale, uint @bias, GlBoolean @abDotProduct, GlBoolean @cdDotProduct, GlBoolean @muxSum);
        void CombinerParameterfNV(uint @pname, float @param);
        void CombinerParameterfvNV(uint @pname, float[] @params);
        void CombinerParameteriNV(uint @pname, int @param);
        void CombinerParameterivNV(uint @pname, int[] @params);
        void CombinerStageParameterfvNV(uint @stage, uint @pname, float[] @params);
        void CommandListSegmentsNV(uint @list, uint @segments);
        void CompileCommandListNV(uint @list);
        void CompileShader(uint @shader);
        void CompileShaderARB(IntPtr @shaderObj);
        void CompileShaderIncludeARB(uint @shader, int @count, byte[][] @path, int[] @length);
        void CompressedMultiTexImage1DEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @border, int @imageSize, byte[] @bits);
        void CompressedMultiTexImage2DEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @border, int @imageSize, byte[] @bits);
        void CompressedMultiTexImage3DEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @depth, int @border, int @imageSize, byte[] @bits);
        void CompressedMultiTexSubImage1DEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, int @xoffset, int @width, GlPixelFormat @format, int @imageSize, byte[] @bits);
        void CompressedMultiTexSubImage2DEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @width, int @height, GlPixelFormat @format, int @imageSize, byte[] @bits);
        void CompressedMultiTexSubImage3DEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, GlPixelFormat @format, int @imageSize, byte[] @bits);
        void CompressedTexImage1D(GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @border, int @imageSize, byte[] @data);
        void CompressedTexImage1DARB(GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @border, int @imageSize, byte[] @data);
        void CompressedTexImage2D(GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @border, int @imageSize, byte[] @data);
        void CompressedTexImage2DARB(GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @border, int @imageSize, byte[] @data);
        void CompressedTexImage3D(GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @depth, int @border, int @imageSize, byte[] @data);
        void CompressedTexImage3DARB(GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @depth, int @border, int @imageSize, byte[] @data);
        void CompressedTexImage3DOES(GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @depth, int @border, int @imageSize, byte[] @data);
        void CompressedTexSubImage1D(GlTextureTarget @target, int @level, int @xoffset, int @width, GlPixelFormat @format, int @imageSize, byte[] @data);
        void CompressedTexSubImage1DARB(GlTextureTarget @target, int @level, int @xoffset, int @width, GlPixelFormat @format, int @imageSize, byte[] @data);
        void CompressedTexSubImage2D(GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @width, int @height, GlPixelFormat @format, int @imageSize, byte[] @data);
        void CompressedTexSubImage2DARB(GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @width, int @height, GlPixelFormat @format, int @imageSize, byte[] @data);
        void CompressedTexSubImage3D(GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, GlPixelFormat @format, int @imageSize, byte[] @data);
        void CompressedTexSubImage3DARB(GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, GlPixelFormat @format, int @imageSize, byte[] @data);
        void CompressedTexSubImage3DOES(GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, GlPixelFormat @format, int @imageSize, byte[] @data);
        void CompressedTextureImage1DEXT(uint @texture, GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @border, int @imageSize, byte[] @bits);
        void CompressedTextureImage2DEXT(uint @texture, GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @border, int @imageSize, byte[] @bits);
        void CompressedTextureImage3DEXT(uint @texture, GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @depth, int @border, int @imageSize, byte[] @bits);
        void CompressedTextureSubImage1D(uint @texture, int @level, int @xoffset, int @width, GlPixelFormat @format, int @imageSize, byte[] @data);
        void CompressedTextureSubImage1DEXT(uint @texture, GlTextureTarget @target, int @level, int @xoffset, int @width, GlPixelFormat @format, int @imageSize, byte[] @bits);
        void CompressedTextureSubImage2D(uint @texture, int @level, int @xoffset, int @yoffset, int @width, int @height, GlPixelFormat @format, int @imageSize, byte[] @data);
        void CompressedTextureSubImage2DEXT(uint @texture, GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @width, int @height, GlPixelFormat @format, int @imageSize, byte[] @bits);
        void CompressedTextureSubImage3D(uint @texture, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, GlPixelFormat @format, int @imageSize, byte[] @data);
        void CompressedTextureSubImage3DEXT(uint @texture, GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, GlPixelFormat @format, int @imageSize, byte[] @bits);
        void ConservativeRasterParameterfNV(uint @pname, float @value);
        void ConservativeRasterParameteriNV(uint @pname, int @param);
        void ConvolutionFilter1D(GlConvolutionTarget @target, GlInternalFormat @internalformat, int @width, GlPixelFormat @format, GlPixelType @type, byte[] @image);
        void ConvolutionFilter1DEXT(GlConvolutionTargetEXT @target, GlInternalFormat @internalformat, int @width, GlPixelFormat @format, GlPixelType @type, byte[] @image);
        void ConvolutionFilter2D(GlConvolutionTarget @target, GlInternalFormat @internalformat, int @width, int @height, GlPixelFormat @format, GlPixelType @type, byte[] @image);
        void ConvolutionFilter2DEXT(GlConvolutionTargetEXT @target, GlInternalFormat @internalformat, int @width, int @height, GlPixelFormat @format, GlPixelType @type, byte[] @image);
        void ConvolutionParameterf(GlConvolutionTarget @target, GlConvolutionParameterEXT @pname, float @params);
        void ConvolutionParameterfEXT(GlConvolutionTargetEXT @target, GlConvolutionParameterEXT @pname, float @params);
        void ConvolutionParameterfv(GlConvolutionTarget @target, GlConvolutionParameterEXT @pname, float[] @params);
        void ConvolutionParameterfvEXT(GlConvolutionTargetEXT @target, GlConvolutionParameterEXT @pname, float[] @params);
        void ConvolutionParameteri(GlConvolutionTarget @target, GlConvolutionParameterEXT @pname, int @params);
        void ConvolutionParameteriEXT(GlConvolutionTargetEXT @target, GlConvolutionParameterEXT @pname, int @params);
        void ConvolutionParameteriv(GlConvolutionTarget @target, GlConvolutionParameterEXT @pname, int[] @params);
        void ConvolutionParameterivEXT(GlConvolutionTargetEXT @target, GlConvolutionParameterEXT @pname, int[] @params);
        void ConvolutionParameterxOES(GlConvolutionTargetEXT @target, GlConvolutionParameterEXT @pname, int @param);
        void ConvolutionParameterxvOES(GlConvolutionTargetEXT @target, GlConvolutionParameterEXT @pname, int[] @params);
        void CopyBufferSubData(GlCopyBufferSubDataTarget @readTarget, GlCopyBufferSubDataTarget @writeTarget, long @readOffset, long @writeOffset, long @size);
        void CopyBufferSubDataNV(GlCopyBufferSubDataTarget @readTarget, GlCopyBufferSubDataTarget @writeTarget, long @readOffset, long @writeOffset, long @size);
        void CopyColorSubTable(GlColorTableTarget @target, int @start, int @x, int @y, int @width);
        void CopyColorSubTableEXT(GlColorTableTarget @target, int @start, int @x, int @y, int @width);
        void CopyColorTable(GlColorTableTarget @target, GlInternalFormat @internalformat, int @x, int @y, int @width);
        void CopyColorTableSGI(GlColorTableTargetSGI @target, GlInternalFormat @internalformat, int @x, int @y, int @width);
        void CopyConvolutionFilter1D(GlConvolutionTarget @target, GlInternalFormat @internalformat, int @x, int @y, int @width);
        void CopyConvolutionFilter1DEXT(GlConvolutionTargetEXT @target, GlInternalFormat @internalformat, int @x, int @y, int @width);
        void CopyConvolutionFilter2D(GlConvolutionTarget @target, GlInternalFormat @internalformat, int @x, int @y, int @width, int @height);
        void CopyConvolutionFilter2DEXT(GlConvolutionTargetEXT @target, GlInternalFormat @internalformat, int @x, int @y, int @width, int @height);
        void CopyImageSubData(uint @srcName, GlCopyBufferSubDataTarget @srcTarget, int @srcLevel, int @srcX, int @srcY, int @srcZ, uint @dstName, GlCopyBufferSubDataTarget @dstTarget, int @dstLevel, int @dstX, int @dstY, int @dstZ, int @srcWidth, int @srcHeight, int @srcDepth);
        void CopyImageSubDataEXT(uint @srcName, GlCopyBufferSubDataTarget @srcTarget, int @srcLevel, int @srcX, int @srcY, int @srcZ, uint @dstName, GlCopyBufferSubDataTarget @dstTarget, int @dstLevel, int @dstX, int @dstY, int @dstZ, int @srcWidth, int @srcHeight, int @srcDepth);
        void CopyImageSubDataNV(uint @srcName, GlCopyBufferSubDataTarget @srcTarget, int @srcLevel, int @srcX, int @srcY, int @srcZ, uint @dstName, GlCopyBufferSubDataTarget @dstTarget, int @dstLevel, int @dstX, int @dstY, int @dstZ, int @width, int @height, int @depth);
        void CopyImageSubDataOES(uint @srcName, GlCopyBufferSubDataTarget @srcTarget, int @srcLevel, int @srcX, int @srcY, int @srcZ, uint @dstName, GlCopyBufferSubDataTarget @dstTarget, int @dstLevel, int @dstX, int @dstY, int @dstZ, int @srcWidth, int @srcHeight, int @srcDepth);
        void CopyMultiTexImage1DEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @x, int @y, int @width, int @border);
        void CopyMultiTexImage2DEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @x, int @y, int @width, int @height, int @border);
        void CopyMultiTexSubImage1DEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, int @xoffset, int @x, int @y, int @width);
        void CopyMultiTexSubImage2DEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @x, int @y, int @width, int @height);
        void CopyMultiTexSubImage3DEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @x, int @y, int @width, int @height);
        void CopyNamedBufferSubData(uint @readBuffer, uint @writeBuffer, long @readOffset, long @writeOffset, long @size);
        void CopyPathNV(uint @resultPath, uint @srcPath);
        void CopyPixels(int @x, int @y, int @width, int @height, GlPixelCopyType @type);
        void CopyTexImage1D(GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @x, int @y, int @width, int @border);
        void CopyTexImage1DEXT(GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @x, int @y, int @width, int @border);
        void CopyTexImage2D(GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @x, int @y, int @width, int @height, int @border);
        void CopyTexImage2DEXT(GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @x, int @y, int @width, int @height, int @border);
        void CopyTexSubImage1D(GlTextureTarget @target, int @level, int @xoffset, int @x, int @y, int @width);
        void CopyTexSubImage1DEXT(GlTextureTarget @target, int @level, int @xoffset, int @x, int @y, int @width);
        void CopyTexSubImage2D(GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @x, int @y, int @width, int @height);
        void CopyTexSubImage2DEXT(GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @x, int @y, int @width, int @height);
        void CopyTexSubImage3D(GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @x, int @y, int @width, int @height);
        void CopyTexSubImage3DEXT(GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @x, int @y, int @width, int @height);
        void CopyTexSubImage3DOES(uint @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @x, int @y, int @width, int @height);
        void CopyTextureImage1DEXT(uint @texture, GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @x, int @y, int @width, int @border);
        void CopyTextureImage2DEXT(uint @texture, GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @x, int @y, int @width, int @height, int @border);
        void CopyTextureLevelsAPPLE(uint @destinationTexture, uint @sourceTexture, int @sourceBaseLevel, int @sourceLevelCount);
        void CopyTextureSubImage1D(uint @texture, int @level, int @xoffset, int @x, int @y, int @width);
        void CopyTextureSubImage1DEXT(uint @texture, GlTextureTarget @target, int @level, int @xoffset, int @x, int @y, int @width);
        void CopyTextureSubImage2D(uint @texture, int @level, int @xoffset, int @yoffset, int @x, int @y, int @width, int @height);
        void CopyTextureSubImage2DEXT(uint @texture, GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @x, int @y, int @width, int @height);
        void CopyTextureSubImage3D(uint @texture, int @level, int @xoffset, int @yoffset, int @zoffset, int @x, int @y, int @width, int @height);
        void CopyTextureSubImage3DEXT(uint @texture, GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @x, int @y, int @width, int @height);
        void CoverFillPathInstancedNV(int @numPaths, GlPathElementType @pathNameType, byte[] @paths, uint @pathBase, GlPathCoverMode @coverMode, GlPathTransformType @transformType, float[] @transformValues);
        void CoverFillPathNV(uint @path, GlPathCoverMode @coverMode);
        void CoverStrokePathInstancedNV(int @numPaths, GlPathElementType @pathNameType, byte[] @paths, uint @pathBase, GlPathCoverMode @coverMode, GlPathTransformType @transformType, float[] @transformValues);
        void CoverStrokePathNV(uint @path, GlPathCoverMode @coverMode);
        void CoverageMaskNV(bool @mask);
        void CoverageModulationNV(uint @components);
        void CoverageModulationTableNV(int @n, float[] @v);
        void CoverageOperationNV(uint @operation);
        void CreateBuffers(int @n, uint[] @buffers);
        void CreateCommandListsNV(int @n, uint[] @lists);
        void CreateFramebuffers(int @n, uint[] @framebuffers);
        void CreateMemoryObjectsEXT(int @n, uint[] @memoryObjects);
        void CreatePerfQueryINTEL(uint @queryId, uint[] @queryHandle);
        uint CreateProgram();
        IntPtr CreateProgramObjectARB();
        void CreateProgramPipelines(int @n, uint[] @pipelines);
        void CreateQueries(GlQueryTarget @target, int @n, uint[] @ids);
        void CreateRenderbuffers(int @n, uint[] @renderbuffers);
        void CreateSamplers(int @n, uint[] @samplers);
        uint CreateShader(GlShaderType @type);
        IntPtr CreateShaderObjectARB(GlShaderType @shaderType);
        uint CreateShaderProgramEXT(GlShaderType @type, byte[] @string);
        uint CreateShaderProgramv(GlShaderType @type, int @count, byte[][] @strings);
        uint CreateShaderProgramvEXT(GlShaderType @type, int @count, byte[][] @strings);
        void CreateStatesNV(int @n, uint[] @states);
        IntPtr CreateSyncFromCLeventARB(IntPtr @context, IntPtr @event, uint @flags);
        void CreateTextures(GlTextureTarget @target, int @n, uint[] @textures);
        void CreateTransformFeedbacks(int @n, uint[] @ids);
        void CreateVertexArrays(int @n, uint[] @arrays);
        void CullFace(GlCullFaceMode @mode);
        void CullParameterdvEXT(uint @pname, double[] @params);
        void CullParameterfvEXT(uint @pname, float[] @params);
        void CurrentPaletteMatrixARB(int @index);
        void CurrentPaletteMatrixOES(uint @matrixpaletteindex);
        void DebugMessageCallback(IntPtr @callback, byte[] @userParam);
        void DebugMessageCallbackAMD(IntPtr @callback, byte[] @userParam);
        void DebugMessageCallbackARB(IntPtr @callback, byte[] @userParam);
        void DebugMessageCallbackKHR(IntPtr @callback, byte[] @userParam);
        void DebugMessageControl(GlDebugSource @source, GlDebugType @type, GlDebugSeverity @severity, int @count, uint[] @ids, GlBoolean @enabled);
        void DebugMessageControlARB(GlDebugSource @source, GlDebugType @type, GlDebugSeverity @severity, int @count, uint[] @ids, GlBoolean @enabled);
        void DebugMessageControlKHR(GlDebugSource @source, GlDebugType @type, GlDebugSeverity @severity, int @count, uint[] @ids, bool @enabled);
        void DebugMessageEnableAMD(uint @category, GlDebugSeverity @severity, int @count, uint[] @ids, GlBoolean @enabled);
        void DebugMessageInsert(GlDebugSource @source, GlDebugType @type, uint @id, GlDebugSeverity @severity, int @length, byte[] @buf);
        void DebugMessageInsertAMD(uint @category, GlDebugSeverity @severity, uint @id, int @length, byte[] @buf);
        void DebugMessageInsertARB(GlDebugSource @source, GlDebugType @type, uint @id, GlDebugSeverity @severity, int @length, byte[] @buf);
        void DebugMessageInsertKHR(GlDebugSource @source, GlDebugType @type, uint @id, GlDebugSeverity @severity, int @length, byte[] @buf);
        void DeformSGIX(GlFfdMaskSGIX @mask);
        void DeformationMap3dSGIX(GlFfdTargetSGIX @target, double @u1, double @u2, int @ustride, int @uorder, double @v1, double @v2, int @vstride, int @vorder, double @w1, double @w2, int @wstride, int @worder, double[] @points);
        void DeformationMap3fSGIX(GlFfdTargetSGIX @target, float @u1, float @u2, int @ustride, int @uorder, float @v1, float @v2, int @vstride, int @vorder, float @w1, float @w2, int @wstride, int @worder, float[] @points);
        void DeleteAsyncMarkersSGIX(uint @marker, int @range);
        void DeleteBuffers(int @n, uint[] @buffers);
        void DeleteBuffersARB(int @n, uint[] @buffers);
        void DeleteCommandListsNV(int @n, uint[] @lists);
        void DeleteFencesAPPLE(int @n, uint[] @fences);
        void DeleteFencesNV(int @n, uint[] @fences);
        void DeleteFragmentShaderATI(uint @id);
        void DeleteFramebuffers(int @n, uint[] @framebuffers);
        void DeleteFramebuffersEXT(int @n, uint[] @framebuffers);
        void DeleteFramebuffersOES(int @n, uint[] @framebuffers);
        void DeleteLists(uint @list, int @range);
        void DeleteMemoryObjectsEXT(int @n, uint[] @memoryObjects);
        void DeleteNamedStringARB(int @namelen, byte[] @name);
        void DeleteNamesAMD(uint @identifier, uint @num, uint[] @names);
        void DeleteObjectARB(IntPtr @obj);
        void DeleteOcclusionQueriesNV(int @n, uint[] @ids);
        void DeletePathsNV(uint @path, int @range);
        void DeletePerfMonitorsAMD(int @n, uint[] @monitors);
        void DeletePerfQueryINTEL(uint @queryHandle);
        void DeleteProgram(uint @program);
        void DeleteProgramPipelines(int @n, uint[] @pipelines);
        void DeleteProgramPipelinesEXT(int @n, uint[] @pipelines);
        void DeleteProgramsARB(int @n, uint[] @programs);
        void DeleteProgramsNV(int @n, uint[] @programs);
        void DeleteQueries(int @n, uint[] @ids);
        void DeleteQueriesARB(int @n, uint[] @ids);
        void DeleteQueriesEXT(int @n, uint[] @ids);
        void DeleteQueryResourceTagNV(int @n, int[] @tagIds);
        void DeleteRenderbuffers(int @n, uint[] @renderbuffers);
        void DeleteRenderbuffersEXT(int @n, uint[] @renderbuffers);
        void DeleteRenderbuffersOES(int @n, uint[] @renderbuffers);
        void DeleteSamplers(int @count, uint[] @samplers);
        void DeleteSemaphoresEXT(int @n, uint[] @semaphores);
        void DeleteShader(uint @shader);
        void DeleteStatesNV(int @n, uint[] @states);
        void DeleteSync(IntPtr @sync);
        void DeleteSyncAPPLE(IntPtr @sync);
        void DeleteTextures(int @n, uint[] @textures);
        void DeleteTexturesEXT(int @n, uint[] @textures);
        void DeleteTransformFeedbacks(int @n, uint[] @ids);
        void DeleteTransformFeedbacksNV(int @n, uint[] @ids);
        void DeleteVertexArrays(int @n, uint[] @arrays);
        void DeleteVertexArraysAPPLE(int @n, uint[] @arrays);
        void DeleteVertexArraysOES(int @n, uint[] @arrays);
        void DeleteVertexShaderEXT(uint @id);
        void DepthBoundsEXT(double @zmin, double @zmax);
        void DepthBoundsdNV(double @zmin, double @zmax);
        void DepthFunc(GlDepthFunction @func);
        void DepthMask(GlBoolean @flag);
        void DepthRange(double @near, double @far);
        void DepthRangeArrayfvNV(uint @first, int @count, float[] @v);
        void DepthRangeArrayfvOES(uint @first, int @count, float[] @v);
        void DepthRangeArrayv(uint @first, int @count, double[] @v);
        void DepthRangeIndexed(uint @index, double @n, double @f);
        void DepthRangeIndexedfNV(uint @index, float @n, float @f);
        void DepthRangeIndexedfOES(uint @index, float @n, float @f);
        void DepthRangedNV(double @zNear, double @zFar);
        void DepthRangef(float @n, float @f);
        void DepthRangefOES(float @n, float @f);
        void DepthRangex(int @n, int @f);
        void DepthRangexOES(int @n, int @f);
        void DetachObjectARB(IntPtr @containerObj, IntPtr @attachedObj);
        void DetachShader(uint @program, uint @shader);
        void DetailTexFuncSGIS(GlTextureTarget @target, int @n, float[] @points);
        void Disable(GlEnableCap @cap);
        void DisableClientState(GlEnableCap @array);
        void DisableClientStateIndexedEXT(GlEnableCap @array, uint @index);
        void DisableClientStateiEXT(GlEnableCap @array, uint @index);
        void DisableDriverControlQCOM(uint @driverControl);
        void DisableIndexedEXT(GlEnableCap @target, uint @index);
        void DisableVariantClientStateEXT(uint @id);
        void DisableVertexArrayAttrib(uint @vaobj, uint @index);
        void DisableVertexArrayAttribEXT(uint @vaobj, uint @index);
        void DisableVertexArrayEXT(uint @vaobj, GlEnableCap @array);
        void DisableVertexAttribAPPLE(uint @index, uint @pname);
        void DisableVertexAttribArray(uint @index);
        void DisableVertexAttribArrayARB(uint @index);
        void Disablei(GlEnableCap @target, uint @index);
        void DisableiEXT(GlEnableCap @target, uint @index);
        void DisableiNV(GlEnableCap @target, uint @index);
        void DisableiOES(GlEnableCap @target, uint @index);
        void DiscardFramebufferEXT(uint @target, int @numAttachments, uint[] @attachments);
        void DispatchCompute(uint @num_groups_x, uint @num_groups_y, uint @num_groups_z);
        void DispatchComputeGroupSizeARB(uint @num_groups_x, uint @num_groups_y, uint @num_groups_z, uint @group_size_x, uint @group_size_y, uint @group_size_z);
        void DispatchComputeIndirect(long @indirect);
        void DrawArrays(GlPrimitiveType @mode, int @first, int @count);
        void DrawArraysEXT(GlPrimitiveType @mode, int @first, int @count);
        void DrawArraysIndirect(GlPrimitiveType @mode, byte[] @indirect);
        void DrawArraysInstanced(GlPrimitiveType @mode, int @first, int @count, int @instancecount);
        void DrawArraysInstancedANGLE(GlPrimitiveType @mode, int @first, int @count, int @primcount);
        void DrawArraysInstancedARB(GlPrimitiveType @mode, int @first, int @count, int @primcount);
        void DrawArraysInstancedBaseInstance(GlPrimitiveType @mode, int @first, int @count, int @instancecount, uint @baseinstance);
        void DrawArraysInstancedBaseInstanceEXT(GlPrimitiveType @mode, int @first, int @count, int @instancecount, uint @baseinstance);
        void DrawArraysInstancedEXT(GlPrimitiveType @mode, int @start, int @count, int @primcount);
        void DrawArraysInstancedNV(GlPrimitiveType @mode, int @first, int @count, int @primcount);
        void DrawBuffer(GlDrawBufferMode @buf);
        void DrawBuffers(int @n, uint[] @bufs);
        void DrawBuffersARB(int @n, uint[] @bufs);
        void DrawBuffersATI(int @n, uint[] @bufs);
        void DrawBuffersEXT(int @n, uint[] @bufs);
        void DrawBuffersIndexedEXT(int @n, uint[] @location, int[] @indices);
        void DrawBuffersNV(int @n, uint[] @bufs);
        void DrawCommandsAddressNV(uint @primitiveMode, ulong[] @indirects, int[] @sizes, uint @count);
        void DrawCommandsNV(uint @primitiveMode, uint @buffer, long[] @indirects, int[] @sizes, uint @count);
        void DrawCommandsStatesAddressNV(ulong[] @indirects, int[] @sizes, uint[] @states, uint[] @fbos, uint @count);
        void DrawCommandsStatesNV(uint @buffer, long[] @indirects, int[] @sizes, uint[] @states, uint[] @fbos, uint @count);
        void DrawElementArrayAPPLE(GlPrimitiveType @mode, int @first, int @count);
        void DrawElementArrayATI(GlPrimitiveType @mode, int @count);
        void DrawElements(GlPrimitiveType @mode, int @count, GlDrawElementsType @type, byte[] @indices);
        void DrawElementsBaseVertex(GlPrimitiveType @mode, int @count, GlDrawElementsType @type, byte[] @indices, int @basevertex);
        void DrawElementsBaseVertexEXT(GlPrimitiveType @mode, int @count, GlDrawElementsType @type, byte[] @indices, int @basevertex);
        void DrawElementsBaseVertexOES(GlPrimitiveType @mode, int @count, GlDrawElementsType @type, byte[] @indices, int @basevertex);
        void DrawElementsIndirect(GlPrimitiveType @mode, GlDrawElementsType @type, byte[] @indirect);
        void DrawElementsInstanced(GlPrimitiveType @mode, int @count, GlDrawElementsType @type, byte[] @indices, int @instancecount);
        void DrawElementsInstancedANGLE(GlPrimitiveType @mode, int @count, GlPrimitiveType @type, byte[] @indices, int @primcount);
        void DrawElementsInstancedARB(GlPrimitiveType @mode, int @count, GlDrawElementsType @type, byte[] @indices, int @primcount);
        void DrawElementsInstancedBaseInstance(GlPrimitiveType @mode, int @count, GlPrimitiveType @type, byte[] @indices, int @instancecount, uint @baseinstance);
        void DrawElementsInstancedBaseInstanceEXT(GlPrimitiveType @mode, int @count, GlPrimitiveType @type, byte[] @indices, int @instancecount, uint @baseinstance);
        void DrawElementsInstancedBaseVertex(GlPrimitiveType @mode, int @count, GlDrawElementsType @type, byte[] @indices, int @instancecount, int @basevertex);
        void DrawElementsInstancedBaseVertexBaseInstance(GlPrimitiveType @mode, int @count, GlPrimitiveType @type, byte[] @indices, int @instancecount, int @basevertex, uint @baseinstance);
        void DrawElementsInstancedBaseVertexBaseInstanceEXT(GlPrimitiveType @mode, int @count, GlPrimitiveType @type, byte[] @indices, int @instancecount, int @basevertex, uint @baseinstance);
        void DrawElementsInstancedBaseVertexEXT(GlPrimitiveType @mode, int @count, GlDrawElementsType @type, byte[] @indices, int @instancecount, int @basevertex);
        void DrawElementsInstancedBaseVertexOES(GlPrimitiveType @mode, int @count, GlDrawElementsType @type, byte[] @indices, int @instancecount, int @basevertex);
        void DrawElementsInstancedEXT(GlPrimitiveType @mode, int @count, GlDrawElementsType @type, byte[] @indices, int @primcount);
        void DrawElementsInstancedNV(GlPrimitiveType @mode, int @count, GlPrimitiveType @type, byte[] @indices, int @primcount);
        void DrawMeshArraysSUN(GlPrimitiveType @mode, int @first, int @count, int @width);
        void DrawPixels(int @width, int @height, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void DrawRangeElementArrayAPPLE(GlPrimitiveType @mode, uint @start, uint @end, int @first, int @count);
        void DrawRangeElementArrayATI(GlPrimitiveType @mode, uint @start, uint @end, int @count);
        void DrawRangeElements(GlPrimitiveType @mode, uint @start, uint @end, int @count, GlDrawElementsType @type, byte[] @indices);
        void DrawRangeElementsBaseVertex(GlPrimitiveType @mode, uint @start, uint @end, int @count, GlDrawElementsType @type, byte[] @indices, int @basevertex);
        void DrawRangeElementsBaseVertexEXT(GlPrimitiveType @mode, uint @start, uint @end, int @count, GlDrawElementsType @type, byte[] @indices, int @basevertex);
        void DrawRangeElementsBaseVertexOES(GlPrimitiveType @mode, uint @start, uint @end, int @count, GlDrawElementsType @type, byte[] @indices, int @basevertex);
        void DrawRangeElementsEXT(GlPrimitiveType @mode, uint @start, uint @end, int @count, GlDrawElementsType @type, byte[] @indices);
        void DrawTexfOES(float @x, float @y, float @z, float @width, float @height);
        void DrawTexfvOES(float[] @coords);
        void DrawTexiOES(int @x, int @y, int @z, int @width, int @height);
        void DrawTexivOES(int[] @coords);
        void DrawTexsOES(short @x, short @y, short @z, short @width, short @height);
        void DrawTexsvOES(short[] @coords);
        void DrawTextureNV(uint @texture, uint @sampler, float @x0, float @y0, float @x1, float @y1, float @z, float @s0, float @t0, float @s1, float @t1);
        void DrawTexxOES(int @x, int @y, int @z, int @width, int @height);
        void DrawTexxvOES(int[] @coords);
        void DrawTransformFeedback(GlPrimitiveType @mode, uint @id);
        void DrawTransformFeedbackEXT(GlPrimitiveType @mode, uint @id);
        void DrawTransformFeedbackInstanced(GlPrimitiveType @mode, uint @id, int @instancecount);
        void DrawTransformFeedbackInstancedEXT(GlPrimitiveType @mode, uint @id, int @instancecount);
        void DrawTransformFeedbackNV(GlPrimitiveType @mode, uint @id);
        void DrawTransformFeedbackStream(GlPrimitiveType @mode, uint @id, uint @stream);
        void DrawTransformFeedbackStreamInstanced(GlPrimitiveType @mode, uint @id, uint @stream, int @instancecount);
        void EGLImageTargetRenderbufferStorageOES(uint @target, byte[] @image);
        void EGLImageTargetTexture2DOES(uint @target, byte[] @image);
        void EdgeFlag(GlBoolean @flag);
        void EdgeFlagFormatNV(int @stride);
        void EdgeFlagPointer(int @stride, byte[] @pointer);
        void EdgeFlagPointerEXT(int @stride, int @count, GlBoolean[] @pointer);
        void EdgeFlagPointerListIBM(int @stride, bool[][] @pointer, int @ptrstride);
        void EdgeFlagv(GlBoolean[] @flag);
        void ElementPointerAPPLE(uint @type, byte[] @pointer);
        void ElementPointerATI(uint @type, byte[] @pointer);
        void Enable(GlEnableCap @cap);
        void EnableClientState(GlEnableCap @array);
        void EnableClientStateIndexedEXT(GlEnableCap @array, uint @index);
        void EnableClientStateiEXT(GlEnableCap @array, uint @index);
        void EnableDriverControlQCOM(uint @driverControl);
        void EnableIndexedEXT(GlEnableCap @target, uint @index);
        void EnableVariantClientStateEXT(uint @id);
        void EnableVertexArrayAttrib(uint @vaobj, uint @index);
        void EnableVertexArrayAttribEXT(uint @vaobj, uint @index);
        void EnableVertexArrayEXT(uint @vaobj, GlEnableCap @array);
        void EnableVertexAttribAPPLE(uint @index, uint @pname);
        void EnableVertexAttribArray(uint @index);
        void EnableVertexAttribArrayARB(uint @index);
        void Enablei(GlEnableCap @target, uint @index);
        void EnableiEXT(GlEnableCap @target, uint @index);
        void EnableiNV(GlEnableCap @target, uint @index);
        void EnableiOES(GlEnableCap @target, uint @index);
        void End();
        void EndConditionalRender();
        void EndConditionalRenderNV();
        void EndConditionalRenderNVX();
        void EndFragmentShaderATI();
        void EndList();
        void EndOcclusionQueryNV();
        void EndPerfMonitorAMD(uint @monitor);
        void EndPerfQueryINTEL(uint @queryHandle);
        void EndQuery(GlQueryTarget @target);
        void EndQueryARB(GlQueryTarget @target);
        void EndQueryEXT(GlQueryTarget @target);
        void EndQueryIndexed(GlQueryTarget @target, uint @index);
        void EndTilingQCOM(GlBufferBitQCOM @preserveMask);
        void EndTransformFeedback();
        void EndTransformFeedbackEXT();
        void EndTransformFeedbackNV();
        void EndVertexShaderEXT();
        void EndVideoCaptureNV(uint @video_capture_slot);
        void EvalCoord1d(double @u);
        void EvalCoord1dv(double[] @u);
        void EvalCoord1f(float @u);
        void EvalCoord1fv(float[] @u);
        void EvalCoord1xOES(int @u);
        void EvalCoord1xvOES(int[] @coords);
        void EvalCoord2d(double @u, double @v);
        void EvalCoord2dv(double[] @u);
        void EvalCoord2f(float @u, float @v);
        void EvalCoord2fv(float[] @u);
        void EvalCoord2xOES(int @u, int @v);
        void EvalCoord2xvOES(int[] @coords);
        void EvalMapsNV(uint @target, uint @mode);
        void EvalMesh1(GlMeshMode1 @mode, int @i1, int @i2);
        void EvalMesh2(GlMeshMode2 @mode, int @i1, int @i2, int @j1, int @j2);
        void EvalPoint1(int @i);
        void EvalPoint2(int @i, int @j);
        void EvaluateDepthValuesARB();
        void ExecuteProgramNV(uint @target, uint @id, float[] @params);
        void ExtGetBufferPointervQCOM(uint @target, byte[][] @params);
        void ExtGetBuffersQCOM(uint[] @buffers, int @maxBuffers, int[] @numBuffers);
        void ExtGetFramebuffersQCOM(uint[] @framebuffers, int @maxFramebuffers, int[] @numFramebuffers);
        void ExtGetProgramBinarySourceQCOM(uint @program, GlShaderType @shadertype, byte[] @source, int[] @length);
        void ExtGetProgramsQCOM(uint[] @programs, int @maxPrograms, int[] @numPrograms);
        void ExtGetRenderbuffersQCOM(uint[] @renderbuffers, int @maxRenderbuffers, int[] @numRenderbuffers);
        void ExtGetShadersQCOM(uint[] @shaders, int @maxShaders, int[] @numShaders);
        void ExtGetTexLevelParameterivQCOM(uint @texture, uint @face, int @level, uint @pname, int[] @params);
        void ExtGetTexSubImageQCOM(uint @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, GlPixelFormat @format, GlPixelType @type, byte[] @texels);
        void ExtGetTexturesQCOM(uint[] @textures, int @maxTextures, int[] @numTextures);
        bool ExtIsProgramBinaryQCOM(uint @program);
        void ExtTexObjectStateOverrideiQCOM(uint @target, uint @pname, int @param);
        void ExtractComponentEXT(uint @res, uint @src, uint @num);
        void FeedbackBuffer(int @size, GlFeedbackType @type, float[] @buffer);
        void FeedbackBufferxOES(int @n, uint @type, int[] @buffer);
        IntPtr FenceSync(GlSyncCondition @condition, uint @flags);
        IntPtr FenceSyncAPPLE(GlSyncCondition @condition, uint @flags);
        void FinalCombinerInputNV(uint @variable, uint @input, uint @mapping, uint @componentUsage);
        void Finish();
        int FinishAsyncSGIX(uint[] @markerp);
        void FinishFenceAPPLE(uint @fence);
        void FinishFenceNV(uint @fence);
        void FinishObjectAPPLE(uint @object, int @name);
        void FinishTextureSUNX();
        void Flush();
        void FlushMappedBufferRange(GlBufferTargetARB @target, long @offset, long @length);
        void FlushMappedBufferRangeAPPLE(GlBufferTargetARB @target, long @offset, long @size);
        void FlushMappedBufferRangeEXT(GlBufferTargetARB @target, long @offset, long @length);
        void FlushMappedNamedBufferRange(uint @buffer, long @offset, long @length);
        void FlushMappedNamedBufferRangeEXT(uint @buffer, long @offset, long @length);
        void FlushPixelDataRangeNV(uint @target);
        void FlushRasterSGIX();
        void FlushStaticDataIBM(uint @target);
        void FlushVertexArrayRangeAPPLE(int @length, byte[] @pointer);
        void FlushVertexArrayRangeNV();
        void FogCoordFormatNV(uint @type, int @stride);
        void FogCoordPointer(GlFogPointerTypeEXT @type, int @stride, byte[] @pointer);
        void FogCoordPointerEXT(GlFogPointerTypeEXT @type, int @stride, byte[] @pointer);
        void FogCoordPointerListIBM(GlFogPointerTypeIBM @type, int @stride, byte[][] @pointer, int @ptrstride);
        void FogCoordd(double @coord);
        void FogCoorddEXT(double @coord);
        void FogCoorddv(double[] @coord);
        void FogCoorddvEXT(double[] @coord);
        void FogCoordf(float @coord);
        void FogCoordfEXT(float @coord);
        void FogCoordfv(float[] @coord);
        void FogCoordfvEXT(float[] @coord);
        void FogCoordhNV(ushort @fog);
        void FogCoordhvNV(ushort[] @fog);
        void FogFuncSGIS(int @n, float[] @points);
        void Fogf(GlFogParameter @pname, float @param);
        void Fogfv(GlFogParameter @pname, float[] @params);
        void Fogi(GlFogParameter @pname, int @param);
        void Fogiv(GlFogParameter @pname, int[] @params);
        void Fogx(GlFogPName @pname, int @param);
        void FogxOES(GlFogPName @pname, int @param);
        void Fogxv(GlFogPName @pname, int[] @param);
        void FogxvOES(GlFogPName @pname, int[] @param);
        void FragmentColorMaterialSGIX(GlMaterialFace @face, GlMaterialParameter @mode);
        void FragmentCoverageColorNV(uint @color);
        void FragmentLightModelfSGIX(GlFragmentLightModelParameterSGIX @pname, float @param);
        void FragmentLightModelfvSGIX(GlFragmentLightModelParameterSGIX @pname, float[] @params);
        void FragmentLightModeliSGIX(GlFragmentLightModelParameterSGIX @pname, int @param);
        void FragmentLightModelivSGIX(GlFragmentLightModelParameterSGIX @pname, int[] @params);
        void FragmentLightfSGIX(uint @light, uint @pname, float @param);
        void FragmentLightfvSGIX(uint @light, uint @pname, float[] @params);
        void FragmentLightiSGIX(uint @light, uint @pname, int @param);
        void FragmentLightivSGIX(uint @light, uint @pname, int[] @params);
        void FragmentMaterialfSGIX(GlMaterialFace @face, GlMaterialParameter @pname, float @param);
        void FragmentMaterialfvSGIX(GlMaterialFace @face, GlMaterialParameter @pname, float[] @params);
        void FragmentMaterialiSGIX(GlMaterialFace @face, GlMaterialParameter @pname, int @param);
        void FragmentMaterialivSGIX(GlMaterialFace @face, GlMaterialParameter @pname, int[] @params);
        void FrameTerminatorGREMEDY();
        void FrameZoomSGIX(int @factor);
        void FramebufferDrawBufferEXT(uint @framebuffer, GlDrawBufferMode @mode);
        void FramebufferDrawBuffersEXT(uint @framebuffer, int @n, GlDrawBufferMode[] @bufs);
        void FramebufferFetchBarrierQCOM();
        void FramebufferFoveationConfigQCOM(uint @framebuffer, uint @numLayers, uint @focalPointsPerLayer, uint @requestedFeatures, uint[] @providedFeatures);
        void FramebufferFoveationParametersQCOM(uint @framebuffer, uint @layer, uint @focalPoint, float @focalX, float @focalY, float @gainX, float @gainY, float @foveaArea);
        void FramebufferParameteri(GlFramebufferTarget @target, GlFramebufferParameterName @pname, int @param);
        void FramebufferPixelLocalStorageSizeEXT(uint @target, int @size);
        void FramebufferReadBufferEXT(uint @framebuffer, GlReadBufferMode @mode);
        void FramebufferRenderbuffer(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, GlRenderbufferTarget @renderbuffertarget, uint @renderbuffer);
        void FramebufferRenderbufferEXT(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, GlRenderbufferTarget @renderbuffertarget, uint @renderbuffer);
        void FramebufferRenderbufferOES(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, GlRenderbufferTarget @renderbuffertarget, uint @renderbuffer);
        void FramebufferSampleLocationsfvARB(GlFramebufferTarget @target, uint @start, int @count, float[] @v);
        void FramebufferSampleLocationsfvNV(GlFramebufferTarget @target, uint @start, int @count, float[] @v);
        void FramebufferSamplePositionsfvAMD(GlFramebufferTarget @target, uint @numsamples, uint @pixelindex, float[] @values);
        void FramebufferTexture(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, uint @texture, int @level);
        void FramebufferTexture1D(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, GlTextureTarget @textarget, uint @texture, int @level);
        void FramebufferTexture1DEXT(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, GlTextureTarget @textarget, uint @texture, int @level);
        void FramebufferTexture2D(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, GlTextureTarget @textarget, uint @texture, int @level);
        void FramebufferTexture2DEXT(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, GlTextureTarget @textarget, uint @texture, int @level);
        void FramebufferTexture2DDownsampleIMG(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, GlTextureTarget @textarget, uint @texture, int @level, int @xscale, int @yscale);
        void FramebufferTexture2DMultisampleEXT(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, GlTextureTarget @textarget, uint @texture, int @level, int @samples);
        void FramebufferTexture2DMultisampleIMG(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, GlTextureTarget @textarget, uint @texture, int @level, int @samples);
        void FramebufferTexture2DOES(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, GlTextureTarget @textarget, uint @texture, int @level);
        void FramebufferTexture3D(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, GlTextureTarget @textarget, uint @texture, int @level, int @zoffset);
        void FramebufferTexture3DEXT(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, GlTextureTarget @textarget, uint @texture, int @level, int @zoffset);
        void FramebufferTexture3DOES(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, GlTextureTarget @textarget, uint @texture, int @level, int @zoffset);
        void FramebufferTextureARB(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, uint @texture, int @level);
        void FramebufferTextureEXT(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, uint @texture, int @level);
        void FramebufferTextureFaceARB(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, uint @texture, int @level, GlTextureTarget @face);
        void FramebufferTextureFaceEXT(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, uint @texture, int @level, GlTextureTarget @face);
        void FramebufferTextureLayer(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, uint @texture, int @level, int @layer);
        void FramebufferTextureLayerARB(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, uint @texture, int @level, int @layer);
        void FramebufferTextureLayerEXT(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, uint @texture, int @level, int @layer);
        void FramebufferTextureLayerDownsampleIMG(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, uint @texture, int @level, int @layer, int @xscale, int @yscale);
        void FramebufferTextureMultisampleMultiviewOVR(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, uint @texture, int @level, int @samples, int @baseViewIndex, int @numViews);
        void FramebufferTextureMultiviewOVR(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, uint @texture, int @level, int @baseViewIndex, int @numViews);
        void FramebufferTextureOES(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, uint @texture, int @level);
        void FreeObjectBufferATI(uint @buffer);
        void FrontFace(GlFrontFaceDirection @mode);
        void Frustum(double @left, double @right, double @bottom, double @top, double @zNear, double @zFar);
        void Frustumf(float @l, float @r, float @b, float @t, float @n, float @f);
        void FrustumfOES(float @l, float @r, float @b, float @t, float @n, float @f);
        void Frustumx(int @l, int @r, int @b, int @t, int @n, int @f);
        void FrustumxOES(int @l, int @r, int @b, int @t, int @n, int @f);
        uint GenAsyncMarkersSGIX(int @range);
        void GenBuffers(int @n, uint[] @buffers);
        void GenBuffersARB(int @n, uint[] @buffers);
        void GenFencesAPPLE(int @n, uint[] @fences);
        void GenFencesNV(int @n, uint[] @fences);
        uint GenFragmentShadersATI(uint @range);
        void GenFramebuffers(int @n, uint[] @framebuffers);
        void GenFramebuffersEXT(int @n, uint[] @framebuffers);
        void GenFramebuffersOES(int @n, uint[] @framebuffers);
        uint GenLists(int @range);
        void GenNamesAMD(uint @identifier, uint @num, uint[] @names);
        void GenOcclusionQueriesNV(int @n, uint[] @ids);
        uint GenPathsNV(int @range);
        void GenPerfMonitorsAMD(int @n, uint[] @monitors);
        void GenProgramPipelines(int @n, uint[] @pipelines);
        void GenProgramPipelinesEXT(int @n, uint[] @pipelines);
        void GenProgramsARB(int @n, uint[] @programs);
        void GenProgramsNV(int @n, uint[] @programs);
        void GenQueries(int @n, uint[] @ids);
        void GenQueriesARB(int @n, uint[] @ids);
        void GenQueriesEXT(int @n, uint[] @ids);
        void GenQueryResourceTagNV(int @n, int[] @tagIds);
        void GenRenderbuffers(int @n, uint[] @renderbuffers);
        void GenRenderbuffersEXT(int @n, uint[] @renderbuffers);
        void GenRenderbuffersOES(int @n, uint[] @renderbuffers);
        void GenSamplers(int @count, uint[] @samplers);
        void GenSemaphoresEXT(int @n, uint[] @semaphores);
        uint GenSymbolsEXT(uint @datatype, uint @storagetype, uint @range, uint @components);
        void GenTextures(int @n, uint[] @textures);
        void GenTexturesEXT(int @n, uint[] @textures);
        void GenTransformFeedbacks(int @n, uint[] @ids);
        void GenTransformFeedbacksNV(int @n, uint[] @ids);
        void GenVertexArrays(int @n, uint[] @arrays);
        void GenVertexArraysAPPLE(int @n, uint[] @arrays);
        void GenVertexArraysOES(int @n, uint[] @arrays);
        uint GenVertexShadersEXT(uint @range);
        void GenerateMipmap(GlTextureTarget @target);
        void GenerateMipmapEXT(GlTextureTarget @target);
        void GenerateMipmapOES(GlTextureTarget @target);
        void GenerateMultiTexMipmapEXT(GlTextureUnit @texunit, GlTextureTarget @target);
        void GenerateTextureMipmap(uint @texture);
        void GenerateTextureMipmapEXT(uint @texture, GlTextureTarget @target);
        void GetActiveAtomicCounterBufferiv(uint @program, uint @bufferIndex, GlAtomicCounterBufferPName @pname, int[] @params);
        void GetActiveAttrib(uint @program, uint @index, int @bufSize, int[] @length, int[] @size, GlAttributeType[] @type, byte[] @name);
        void GetActiveAttribARB(IntPtr @programObj, uint @index, int @maxLength, int[] @length, int[] @size, GlAttributeType[] @type, byte[] @name);
        void GetActiveSubroutineName(uint @program, GlShaderType @shadertype, uint @index, int @bufsize, int[] @length, byte[] @name);
        void GetActiveSubroutineUniformName(uint @program, GlShaderType @shadertype, uint @index, int @bufsize, int[] @length, byte[] @name);
        void GetActiveSubroutineUniformiv(uint @program, GlShaderType @shadertype, uint @index, GlSubroutineParameterName @pname, int[] @values);
        void GetActiveUniform(uint @program, uint @index, int @bufSize, int[] @length, int[] @size, GlAttributeType[] @type, byte[] @name);
        void GetActiveUniformARB(IntPtr @programObj, uint @index, int @maxLength, int[] @length, int[] @size, GlAttributeType[] @type, byte[] @name);
        void GetActiveUniformBlockName(uint @program, uint @uniformBlockIndex, int @bufSize, int[] @length, byte[] @uniformBlockName);
        void GetActiveUniformBlockiv(uint @program, uint @uniformBlockIndex, GlUniformBlockPName @pname, int[] @params);
        void GetActiveUniformName(uint @program, uint @uniformIndex, int @bufSize, int[] @length, byte[] @uniformName);
        void GetActiveUniformsiv(uint @program, int @uniformCount, uint[] @uniformIndices, GlUniformPName @pname, int[] @params);
        void GetActiveVaryingNV(uint @program, uint @index, int @bufSize, int[] @length, int[] @size, uint[] @type, byte[] @name);
        void GetArrayObjectfvATI(GlEnableCap @array, uint @pname, float[] @params);
        void GetArrayObjectivATI(GlEnableCap @array, uint @pname, int[] @params);
        void GetAttachedObjectsARB(IntPtr @containerObj, int @maxCount, int[] @count, IntPtr[] @obj);
        void GetAttachedShaders(uint @program, int @maxCount, int[] @count, uint[] @shaders);
        int GetAttribLocation(uint @program, byte[] @name);
        int GetAttribLocationARB(IntPtr @programObj, byte[] @name);
        void GetBooleanIndexedvEXT(GlBufferTargetARB @target, uint @index, GlBoolean[] @data);
        void GetBooleani_v(GlBufferTargetARB @target, uint @index, GlBoolean[] @data);
        void GetBooleanv(GlGetPName @pname, GlBoolean[] @data);
        void GetBufferParameteri64v(GlBufferTargetARB @target, uint @pname, long[] @params);
        void GetBufferParameteriv(GlBufferTargetARB @target, uint @pname, int[] @params);
        void GetBufferParameterivARB(GlBufferTargetARB @target, uint @pname, int[] @params);
        void GetBufferParameterui64vNV(GlBufferTargetARB @target, uint @pname, ulong[] @params);
        void GetBufferPointerv(GlBufferTargetARB @target, uint @pname, byte[][] @params);
        void GetBufferPointervARB(GlBufferTargetARB @target, uint @pname, byte[][] @params);
        void GetBufferPointervOES(GlBufferTargetARB @target, uint @pname, byte[][] @params);
        void GetBufferSubData(GlBufferTargetARB @target, long @offset, long @size, byte[] @data);
        void GetBufferSubDataARB(GlBufferTargetARB @target, long @offset, long @size, byte[] @data);
        void GetClipPlane(GlClipPlaneName @plane, double[] @equation);
        void GetClipPlanef(GlClipPlaneName @plane, float[] @equation);
        void GetClipPlanefOES(GlClipPlaneName @plane, float[] @equation);
        void GetClipPlanex(GlClipPlaneName @plane, int[] @equation);
        void GetClipPlanexOES(GlClipPlaneName @plane, int[] @equation);
        void GetColorTable(GlColorTableTarget @target, GlPixelFormat @format, GlPixelType @type, byte[] @table);
        void GetColorTableEXT(GlColorTableTarget @target, GlPixelFormat @format, GlPixelType @type, byte[] @data);
        void GetColorTableParameterfv(GlColorTableTarget @target, GlGetColorTableParameterPNameSGI @pname, float[] @params);
        void GetColorTableParameterfvEXT(GlColorTableTarget @target, GlGetColorTableParameterPNameSGI @pname, float[] @params);
        void GetColorTableParameterfvSGI(GlColorTableTargetSGI @target, GlGetColorTableParameterPNameSGI @pname, float[] @params);
        void GetColorTableParameteriv(GlColorTableTarget @target, GlGetColorTableParameterPNameSGI @pname, int[] @params);
        void GetColorTableParameterivEXT(GlColorTableTarget @target, GlGetColorTableParameterPNameSGI @pname, int[] @params);
        void GetColorTableParameterivSGI(GlColorTableTargetSGI @target, GlGetColorTableParameterPNameSGI @pname, int[] @params);
        void GetColorTableSGI(GlColorTableTargetSGI @target, GlPixelFormat @format, GlPixelType @type, byte[] @table);
        void GetCombinerInputParameterfvNV(uint @stage, uint @portion, uint @variable, uint @pname, float[] @params);
        void GetCombinerInputParameterivNV(uint @stage, uint @portion, uint @variable, uint @pname, int[] @params);
        void GetCombinerOutputParameterfvNV(uint @stage, uint @portion, uint @pname, float[] @params);
        void GetCombinerOutputParameterivNV(uint @stage, uint @portion, uint @pname, int[] @params);
        void GetCombinerStageParameterfvNV(uint @stage, uint @pname, float[] @params);
        uint GetCommandHeaderNV(uint @tokenID, uint @size);
        void GetCompressedMultiTexImageEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @lod, byte[] @img);
        void GetCompressedTexImage(GlTextureTarget @target, int @level, byte[] @img);
        void GetCompressedTexImageARB(GlTextureTarget @target, int @level, byte[] @img);
        void GetCompressedTextureImage(uint @texture, int @level, int @bufSize, byte[] @pixels);
        void GetCompressedTextureImageEXT(uint @texture, GlTextureTarget @target, int @lod, byte[] @img);
        void GetCompressedTextureSubImage(uint @texture, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, int @bufSize, byte[] @pixels);
        void GetConvolutionFilter(GlConvolutionTarget @target, GlPixelFormat @format, GlPixelType @type, byte[] @image);
        void GetConvolutionFilterEXT(GlConvolutionTargetEXT @target, GlPixelFormat @format, GlPixelType @type, byte[] @image);
        void GetConvolutionParameterfv(GlConvolutionTarget @target, GlConvolutionParameterEXT @pname, float[] @params);
        void GetConvolutionParameterfvEXT(GlConvolutionTargetEXT @target, GlConvolutionParameterEXT @pname, float[] @params);
        void GetConvolutionParameteriv(GlConvolutionTarget @target, GlConvolutionParameterEXT @pname, int[] @params);
        void GetConvolutionParameterivEXT(GlConvolutionTargetEXT @target, GlConvolutionParameterEXT @pname, int[] @params);
        void GetConvolutionParameterxvOES(uint @target, uint @pname, int[] @params);
        void GetCoverageModulationTableNV(int @bufsize, float[] @v);
        uint GetDebugMessageLog(uint @count, int @bufSize, GlDebugSource[] @sources, GlDebugType[] @types, uint[] @ids, GlDebugSeverity[] @severities, int[] @lengths, byte[] @messageLog);
        uint GetDebugMessageLogAMD(uint @count, int @bufsize, uint[] @categories, GlDebugSeverity[] @severities, uint[] @ids, int[] @lengths, byte[] @message);
        uint GetDebugMessageLogARB(uint @count, int @bufSize, GlDebugSource[] @sources, GlDebugType[] @types, uint[] @ids, GlDebugSeverity[] @severities, int[] @lengths, byte[] @messageLog);
        uint GetDebugMessageLogKHR(uint @count, int @bufSize, GlDebugSource[] @sources, GlDebugType[] @types, uint[] @ids, GlDebugSeverity[] @severities, int[] @lengths, byte[] @messageLog);
        void GetDetailTexFuncSGIS(GlTextureTarget @target, float[] @points);
        void GetDoubleIndexedvEXT(GlTypeEnum @target, uint @index, double[] @data);
        void GetDoublei_v(GlTypeEnum @target, uint @index, double[] @data);
        void GetDoublei_vEXT(GlTypeEnum @pname, uint @index, double[] @params);
        void GetDoublev(GlGetPName @pname, double[] @data);
        void GetDriverControlStringQCOM(uint @driverControl, int @bufSize, int[] @length, byte[] @driverControlString);
        void GetDriverControlsQCOM(int[] @num, int @size, uint[] @driverControls);
        uint GetError();
        void GetFenceivNV(uint @fence, uint @pname, int[] @params);
        void GetFinalCombinerInputParameterfvNV(uint @variable, uint @pname, float[] @params);
        void GetFinalCombinerInputParameterivNV(uint @variable, uint @pname, int[] @params);
        void GetFirstPerfQueryIdINTEL(uint[] @queryId);
        void GetFixedv(GlGetPName @pname, int[] @params);
        void GetFixedvOES(GlGetPName @pname, int[] @params);
        void GetFloatIndexedvEXT(GlTypeEnum @target, uint @index, float[] @data);
        void GetFloati_v(GlTypeEnum @target, uint @index, float[] @data);
        void GetFloati_vEXT(GlTypeEnum @pname, uint @index, float[] @params);
        void GetFloati_vNV(GlTypeEnum @target, uint @index, float[] @data);
        void GetFloati_vOES(GlTypeEnum @target, uint @index, float[] @data);
        void GetFloatv(GlGetPName @pname, float[] @data);
        void GetFogFuncSGIS(float[] @points);
        int GetFragDataIndex(uint @program, byte[] @name);
        int GetFragDataIndexEXT(uint @program, byte[] @name);
        int GetFragDataLocation(uint @program, byte[] @name);
        int GetFragDataLocationEXT(uint @program, byte[] @name);
        void GetFragmentLightfvSGIX(uint @light, uint @pname, float[] @params);
        void GetFragmentLightivSGIX(uint @light, uint @pname, int[] @params);
        void GetFragmentMaterialfvSGIX(GlMaterialFace @face, GlMaterialParameter @pname, float[] @params);
        void GetFragmentMaterialivSGIX(GlMaterialFace @face, GlMaterialParameter @pname, int[] @params);
        void GetFramebufferAttachmentParameteriv(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, GlFramebufferAttachmentParameterName @pname, int[] @params);
        void GetFramebufferAttachmentParameterivEXT(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, GlFramebufferAttachmentParameterName @pname, int[] @params);
        void GetFramebufferAttachmentParameterivOES(GlFramebufferTarget @target, GlFramebufferAttachment @attachment, GlFramebufferAttachmentParameterName @pname, int[] @params);
        void GetFramebufferParameterfvAMD(GlFramebufferTarget @target, GlFramebufferAttachmentParameterName @pname, uint @numsamples, uint @pixelindex, int @size, float[] @values);
        void GetFramebufferParameteriv(GlFramebufferTarget @target, GlFramebufferAttachmentParameterName @pname, int[] @params);
        void GetFramebufferParameterivEXT(uint @framebuffer, GlGetFramebufferParameter @pname, int[] @params);
        int GetFramebufferPixelLocalStorageSizeEXT(GlFramebufferTarget @target);
        uint GetGraphicsResetStatus();
        uint GetGraphicsResetStatusARB();
        uint GetGraphicsResetStatusEXT();
        uint GetGraphicsResetStatusKHR();
        IntPtr GetHandleARB(uint @pname);
        void GetHistogram(GlHistogramTargetEXT @target, GlBoolean @reset, GlPixelFormat @format, GlPixelType @type, byte[] @values);
        void GetHistogramEXT(GlHistogramTargetEXT @target, GlBoolean @reset, GlPixelFormat @format, GlPixelType @type, byte[] @values);
        void GetHistogramParameterfv(GlHistogramTargetEXT @target, GlGetHistogramParameterPNameEXT @pname, float[] @params);
        void GetHistogramParameterfvEXT(GlHistogramTargetEXT @target, GlGetHistogramParameterPNameEXT @pname, float[] @params);
        void GetHistogramParameteriv(GlHistogramTargetEXT @target, GlGetHistogramParameterPNameEXT @pname, int[] @params);
        void GetHistogramParameterivEXT(GlHistogramTargetEXT @target, GlGetHistogramParameterPNameEXT @pname, int[] @params);
        void GetHistogramParameterxvOES(GlHistogramTargetEXT @target, GlGetHistogramParameterPNameEXT @pname, int[] @params);
        ulong GetImageHandleARB(uint @texture, int @level, bool @layered, int @layer, GlPixelFormat @format);
        ulong GetImageHandleNV(uint @texture, int @level, GlBoolean @layered, int @layer, GlPixelFormat @format);
        void GetImageTransformParameterfvHP(uint @target, uint @pname, float[] @params);
        void GetImageTransformParameterivHP(uint @target, uint @pname, int[] @params);
        void GetInfoLogARB(IntPtr @obj, int @maxLength, int[] @length, byte[] @infoLog);
        int GetInstrumentsSGIX();
        void GetInteger64i_v(GlTypeEnum @target, uint @index, long[] @data);
        void GetInteger64v(GlGetPName @pname, long[] @data);
        void GetInteger64vAPPLE(GlGetPName @pname, long[] @params);
        void GetIntegerIndexedvEXT(uint @target, uint @index, int[] @data);
        void GetIntegeri_v(GlTypeEnum @target, uint @index, int[] @data);
        void GetIntegeri_vEXT(GlTypeEnum @target, uint @index, int[] @data);
        void GetIntegerui64i_vNV(uint @value, uint @index, ulong[] @result);
        void GetIntegerui64vNV(uint @value, ulong[] @result);
        void GetIntegerv(GlGetPName @pname, int[] @data);
        void GetInternalformatSampleivNV(GlTextureTarget @target, GlInternalFormat @internalformat, int @samples, GlInternalFormatPName @pname, int @bufSize, int[] @params);
        void GetInternalformati64v(GlTextureTarget @target, GlInternalFormat @internalformat, GlInternalFormatPName @pname, int @bufSize, long[] @params);
        void GetInternalformativ(GlTextureTarget @target, GlInternalFormat @internalformat, GlInternalFormatPName @pname, int @bufSize, int[] @params);
        void GetInvariantBooleanvEXT(uint @id, uint @value, GlBoolean[] @data);
        void GetInvariantFloatvEXT(uint @id, uint @value, float[] @data);
        void GetInvariantIntegervEXT(uint @id, uint @value, int[] @data);
        void GetLightfv(GlLightName @light, GlLightParameter @pname, float[] @params);
        void GetLightiv(GlLightName @light, GlLightParameter @pname, int[] @params);
        void GetLightxOES(GlLightName @light, GlLightParameter @pname, int[] @params);
        void GetLightxv(GlLightName @light, GlLightParameter @pname, int[] @params);
        void GetLightxvOES(GlLightName @light, GlLightParameter @pname, int[] @params);
        void GetListParameterfvSGIX(uint @list, GlListParameterName @pname, float[] @params);
        void GetListParameterivSGIX(uint @list, GlListParameterName @pname, int[] @params);
        void GetLocalConstantBooleanvEXT(uint @id, uint @value, GlBoolean[] @data);
        void GetLocalConstantFloatvEXT(uint @id, uint @value, float[] @data);
        void GetLocalConstantIntegervEXT(uint @id, uint @value, int[] @data);
        void GetMapAttribParameterfvNV(uint @target, uint @index, uint @pname, float[] @params);
        void GetMapAttribParameterivNV(uint @target, uint @index, uint @pname, int[] @params);
        void GetMapControlPointsNV(uint @target, uint @index, uint @type, int @ustride, int @vstride, GlBoolean @packed, byte[] @points);
        void GetMapParameterfvNV(uint @target, uint @pname, float[] @params);
        void GetMapParameterivNV(uint @target, uint @pname, int[] @params);
        void GetMapdv(GlMapTarget @target, GlGetMapQuery @query, double[] @v);
        void GetMapfv(GlMapTarget @target, GlGetMapQuery @query, float[] @v);
        void GetMapiv(GlMapTarget @target, GlGetMapQuery @query, int[] @v);
        void GetMapxvOES(GlMapTarget @target, GlGetMapQuery @query, int[] @v);
        void GetMaterialfv(GlMaterialFace @face, GlMaterialParameter @pname, float[] @params);
        void GetMaterialiv(GlMaterialFace @face, GlMaterialParameter @pname, int[] @params);
        void GetMaterialxOES(GlMaterialFace @face, GlMaterialParameter @pname, int @param);
        void GetMaterialxv(GlMaterialFace @face, GlMaterialParameter @pname, int[] @params);
        void GetMaterialxvOES(GlMaterialFace @face, GlMaterialParameter @pname, int[] @params);
        void GetMemoryObjectParameterivEXT(uint @memoryObject, GlMemoryObjectParameterName @pname, int[] @params);
        void GetMinmax(GlMinmaxTargetEXT @target, GlBoolean @reset, GlPixelFormat @format, GlPixelType @type, byte[] @values);
        void GetMinmaxEXT(GlMinmaxTargetEXT @target, GlBoolean @reset, GlPixelFormat @format, GlPixelType @type, byte[] @values);
        void GetMinmaxParameterfv(GlMinmaxTargetEXT @target, GlGetMinmaxParameterPNameEXT @pname, float[] @params);
        void GetMinmaxParameterfvEXT(GlMinmaxTargetEXT @target, GlGetMinmaxParameterPNameEXT @pname, float[] @params);
        void GetMinmaxParameteriv(GlMinmaxTargetEXT @target, GlGetMinmaxParameterPNameEXT @pname, int[] @params);
        void GetMinmaxParameterivEXT(GlMinmaxTargetEXT @target, GlGetMinmaxParameterPNameEXT @pname, int[] @params);
        void GetMultiTexEnvfvEXT(GlTextureUnit @texunit, GlTextureEnvTarget @target, GlTextureEnvParameter @pname, float[] @params);
        void GetMultiTexEnvivEXT(GlTextureUnit @texunit, GlTextureEnvTarget @target, GlTextureEnvParameter @pname, int[] @params);
        void GetMultiTexGendvEXT(GlTextureUnit @texunit, GlTextureCoordName @coord, GlTextureGenParameter @pname, double[] @params);
        void GetMultiTexGenfvEXT(GlTextureUnit @texunit, GlTextureCoordName @coord, GlTextureGenParameter @pname, float[] @params);
        void GetMultiTexGenivEXT(GlTextureUnit @texunit, GlTextureCoordName @coord, GlTextureGenParameter @pname, int[] @params);
        void GetMultiTexImageEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void GetMultiTexLevelParameterfvEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, GlGetTextureParameter @pname, float[] @params);
        void GetMultiTexLevelParameterivEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, GlGetTextureParameter @pname, int[] @params);
        void GetMultiTexParameterIivEXT(GlTextureUnit @texunit, GlTextureTarget @target, GlGetTextureParameter @pname, int[] @params);
        void GetMultiTexParameterIuivEXT(GlTextureUnit @texunit, GlTextureTarget @target, GlGetTextureParameter @pname, uint[] @params);
        void GetMultiTexParameterfvEXT(GlTextureUnit @texunit, GlTextureTarget @target, GlGetTextureParameter @pname, float[] @params);
        void GetMultiTexParameterivEXT(GlTextureUnit @texunit, GlTextureTarget @target, GlGetTextureParameter @pname, int[] @params);
        void GetMultisamplefv(uint @pname, uint @index, float[] @val);
        void GetMultisamplefvNV(uint @pname, uint @index, float[] @val);
        void GetNamedBufferParameteri64v(uint @buffer, GlVertexBufferObjectParameter @pname, long[] @params);
        void GetNamedBufferParameteriv(uint @buffer, GlVertexBufferObjectParameter @pname, int[] @params);
        void GetNamedBufferParameterivEXT(uint @buffer, GlVertexBufferObjectParameter @pname, int[] @params);
        void GetNamedBufferParameterui64vNV(uint @buffer, GlVertexBufferObjectParameter @pname, ulong[] @params);
        void GetNamedBufferPointerv(uint @buffer, GlVertexBufferObjectParameter @pname, byte[][] @params);
        void GetNamedBufferPointervEXT(uint @buffer, GlVertexBufferObjectParameter @pname, byte[][] @params);
        void GetNamedBufferSubData(uint @buffer, long @offset, long @size, byte[] @data);
        void GetNamedBufferSubDataEXT(uint @buffer, long @offset, long @size, byte[] @data);
        void GetNamedFramebufferParameterfvAMD(uint @framebuffer, uint @pname, uint @numsamples, uint @pixelindex, int @size, float[] @values);
        void GetNamedFramebufferAttachmentParameteriv(uint @framebuffer, GlFramebufferAttachment @attachment, GlFramebufferAttachmentParameterName @pname, int[] @params);
        void GetNamedFramebufferAttachmentParameterivEXT(uint @framebuffer, GlFramebufferAttachment @attachment, GlFramebufferAttachmentParameterName @pname, int[] @params);
        void GetNamedFramebufferParameteriv(uint @framebuffer, GlGetFramebufferParameter @pname, int[] @param);
        void GetNamedFramebufferParameterivEXT(uint @framebuffer, GlGetFramebufferParameter @pname, int[] @params);
        void GetNamedProgramLocalParameterIivEXT(uint @program, uint @target, uint @index, int[] @params);
        void GetNamedProgramLocalParameterIuivEXT(uint @program, uint @target, uint @index, uint[] @params);
        void GetNamedProgramLocalParameterdvEXT(uint @program, uint @target, uint @index, double[] @params);
        void GetNamedProgramLocalParameterfvEXT(uint @program, uint @target, uint @index, float[] @params);
        void GetNamedProgramStringEXT(uint @program, uint @target, uint @pname, byte[] @string);
        void GetNamedProgramivEXT(uint @program, uint @target, GlProgramPropertyARB @pname, int[] @params);
        void GetNamedRenderbufferParameteriv(uint @renderbuffer, GlRenderbufferParameterName @pname, int[] @params);
        void GetNamedRenderbufferParameterivEXT(uint @renderbuffer, GlRenderbufferParameterName @pname, int[] @params);
        void GetNamedStringARB(int @namelen, byte[] @name, int @bufSize, int[] @stringlen, byte[] @string);
        void GetNamedStringivARB(int @namelen, byte[] @name, uint @pname, int[] @params);
        void GetNextPerfQueryIdINTEL(uint @queryId, uint[] @nextQueryId);
        void GetObjectBufferfvATI(uint @buffer, uint @pname, float[] @params);
        void GetObjectBufferivATI(uint @buffer, uint @pname, int[] @params);
        void GetObjectLabel(uint @identifier, uint @name, int @bufSize, int[] @length, byte[] @label);
        void GetObjectLabelEXT(uint @type, uint @object, int @bufSize, int[] @length, byte[] @label);
        void GetObjectLabelKHR(uint @identifier, uint @name, int @bufSize, int[] @length, byte[] @label);
        void GetObjectParameterfvARB(IntPtr @obj, uint @pname, float[] @params);
        void GetObjectParameterivAPPLE(uint @objectType, uint @name, uint @pname, int[] @params);
        void GetObjectParameterivARB(IntPtr @obj, uint @pname, int[] @params);
        void GetObjectPtrLabel(byte[] @ptr, int @bufSize, int[] @length, byte[] @label);
        void GetObjectPtrLabelKHR(byte[] @ptr, int @bufSize, int[] @length, byte[] @label);
        void GetOcclusionQueryivNV(uint @id, uint @pname, int[] @params);
        void GetOcclusionQueryuivNV(uint @id, uint @pname, uint[] @params);
        void GetPathColorGenfvNV(GlPathColor @color, GlPathGenMode @pname, float[] @value);
        void GetPathColorGenivNV(GlPathColor @color, GlPathGenMode @pname, int[] @value);
        void GetPathCommandsNV(uint @path, byte[] @commands);
        void GetPathCoordsNV(uint @path, float[] @coords);
        void GetPathDashArrayNV(uint @path, float[] @dashArray);
        float GetPathLengthNV(uint @path, int @startSegment, int @numSegments);
        void GetPathMetricRangeNV(GlPathMetricMask @metricQueryMask, uint @firstPathName, int @numPaths, int @stride, float[] @metrics);
        void GetPathMetricsNV(GlPathMetricMask @metricQueryMask, int @numPaths, GlPathElementType @pathNameType, byte[] @paths, uint @pathBase, int @stride, float[] @metrics);
        void GetPathParameterfvNV(uint @path, GlPathParameter @pname, float[] @value);
        void GetPathParameterivNV(uint @path, GlPathParameter @pname, int[] @value);
        void GetPathSpacingNV(GlPathListMode @pathListMode, int @numPaths, GlPathElementType @pathNameType, byte[] @paths, uint @pathBase, float @advanceScale, float @kerningScale, GlPathTransformType @transformType, float[] @returnedSpacing);
        void GetPathTexGenfvNV(GlTextureUnit @texCoordSet, GlPathGenMode @pname, float[] @value);
        void GetPathTexGenivNV(GlTextureUnit @texCoordSet, GlPathGenMode @pname, int[] @value);
        void GetPerfCounterInfoINTEL(uint @queryId, uint @counterId, uint @counterNameLength, byte[] @counterName, uint @counterDescLength, byte[] @counterDesc, uint[] @counterOffset, uint[] @counterDataSize, uint[] @counterTypeEnum, uint[] @counterDataTypeEnum, ulong[] @rawCounterMaxValue);
        void GetPerfMonitorCounterDataAMD(uint @monitor, uint @pname, int @dataSize, uint[] @data, int[] @bytesWritten);
        void GetPerfMonitorCounterInfoAMD(uint @group, uint @counter, uint @pname, byte[] @data);
        void GetPerfMonitorCounterStringAMD(uint @group, uint @counter, int @bufSize, int[] @length, byte[] @counterString);
        void GetPerfMonitorCountersAMD(uint @group, int[] @numCounters, int[] @maxActiveCounters, int @counterSize, uint[] @counters);
        void GetPerfMonitorGroupStringAMD(uint @group, int @bufSize, int[] @length, byte[] @groupString);
        void GetPerfMonitorGroupsAMD(int[] @numGroups, int @groupsSize, uint[] @groups);
        void GetPerfQueryDataINTEL(uint @queryHandle, uint @flags, int @dataSize, byte[] @data, uint[] @bytesWritten);
        void GetPerfQueryIdByNameINTEL(byte[] @queryName, uint[] @queryId);
        void GetPerfQueryInfoINTEL(uint @queryId, uint @queryNameLength, byte[] @queryName, uint[] @dataSize, uint[] @noCounters, uint[] @noInstances, uint[] @capsMask);
        void GetPixelMapfv(GlPixelMap @map, float[] @values);
        void GetPixelMapuiv(GlPixelMap @map, uint[] @values);
        void GetPixelMapusv(GlPixelMap @map, ushort[] @values);
        void GetPixelMapxv(GlPixelMap @map, int @size, int[] @values);
        void GetPixelTexGenParameterfvSGIS(GlPixelTexGenParameterNameSGIS @pname, float[] @params);
        void GetPixelTexGenParameterivSGIS(GlPixelTexGenParameterNameSGIS @pname, int[] @params);
        void GetPixelTransformParameterfvEXT(GlTypeEnum @target, uint @pname, float[] @params);
        void GetPixelTransformParameterivEXT(GlTypeEnum @target, uint @pname, int[] @params);
        void GetPointerIndexedvEXT(GlTypeEnum @target, uint @index, byte[][] @data);
        void GetPointeri_vEXT(GlTypeEnum @pname, uint @index, byte[][] @params);
        void GetPointerv(GlGetPointervPName @pname, byte[][] @params);
        void GetPointervEXT(GlGetPointervPName @pname, byte[][] @params);
        void GetPointervKHR(uint @pname, byte[][] @params);
        void GetPolygonStipple(byte[] @mask);
        void GetProgramBinary(uint @program, int @bufSize, int[] @length, uint[] @binaryFormat, byte[] @binary);
        void GetProgramBinaryOES(uint @program, int @bufSize, int[] @length, uint[] @binaryFormat, byte[] @binary);
        void GetProgramEnvParameterIivNV(uint @target, uint @index, int[] @params);
        void GetProgramEnvParameterIuivNV(uint @target, uint @index, uint[] @params);
        void GetProgramEnvParameterdvARB(uint @target, uint @index, double[] @params);
        void GetProgramEnvParameterfvARB(uint @target, uint @index, float[] @params);
        void GetProgramInfoLog(uint @program, int @bufSize, int[] @length, byte[] @infoLog);
        void GetProgramInterfaceiv(uint @program, GlProgramInterface @programInterface, GlProgramInterfacePName @pname, int[] @params);
        void GetProgramLocalParameterIivNV(uint @target, uint @index, int[] @params);
        void GetProgramLocalParameterIuivNV(uint @target, uint @index, uint[] @params);
        void GetProgramLocalParameterdvARB(uint @target, uint @index, double[] @params);
        void GetProgramLocalParameterfvARB(uint @target, uint @index, float[] @params);
        void GetProgramNamedParameterdvNV(uint @id, int @len, byte[] @name, double[] @params);
        void GetProgramNamedParameterfvNV(uint @id, int @len, byte[] @name, float[] @params);
        void GetProgramParameterdvNV(uint @target, uint @index, uint @pname, double[] @params);
        void GetProgramParameterfvNV(uint @target, uint @index, uint @pname, float[] @params);
        void GetProgramPipelineInfoLog(uint @pipeline, int @bufSize, int[] @length, byte[] @infoLog);
        void GetProgramPipelineInfoLogEXT(uint @pipeline, int @bufSize, int[] @length, byte[] @infoLog);
        void GetProgramPipelineiv(uint @pipeline, GlPipelineParameterName @pname, int[] @params);
        void GetProgramPipelineivEXT(uint @pipeline, GlPipelineParameterName @pname, int[] @params);
        uint GetProgramResourceIndex(uint @program, GlProgramInterface @programInterface, byte[] @name);
        int GetProgramResourceLocation(uint @program, GlProgramInterface @programInterface, byte[] @name);
        int GetProgramResourceLocationIndex(uint @program, GlProgramInterface @programInterface, byte[] @name);
        int GetProgramResourceLocationIndexEXT(uint @program, GlProgramInterface @programInterface, byte[] @name);
        void GetProgramResourceName(uint @program, GlProgramInterface @programInterface, uint @index, int @bufSize, int[] @length, byte[] @name);
        void GetProgramResourcefvNV(uint @program, GlProgramInterface @programInterface, uint @index, int @propCount, uint[] @props, int @bufSize, int[] @length, float[] @params);
        void GetProgramResourceiv(uint @program, GlProgramInterface @programInterface, uint @index, int @propCount, uint[] @props, int @bufSize, int[] @length, int[] @params);
        void GetProgramStageiv(uint @program, GlShaderType @shadertype, GlProgramStagePName @pname, int[] @values);
        void GetProgramStringARB(uint @target, uint @pname, byte[] @string);
        void GetProgramStringNV(uint @id, uint @pname, byte[] @program);
        void GetProgramSubroutineParameteruivNV(uint @target, uint @index, uint[] @param);
        void GetProgramiv(uint @program, GlProgramPropertyARB @pname, int[] @params);
        void GetProgramivARB(uint @target, GlProgramPropertyARB @pname, int[] @params);
        void GetProgramivNV(uint @id, uint @pname, int[] @params);
        void GetQueryBufferObjecti64v(uint @id, uint @buffer, GlQueryObjectParameterName @pname, long @offset);
        void GetQueryBufferObjectiv(uint @id, uint @buffer, GlQueryObjectParameterName @pname, long @offset);
        void GetQueryBufferObjectui64v(uint @id, uint @buffer, GlQueryObjectParameterName @pname, long @offset);
        void GetQueryBufferObjectuiv(uint @id, uint @buffer, GlQueryObjectParameterName @pname, long @offset);
        void GetQueryIndexediv(uint @target, uint @index, GlQueryParameterName @pname, int[] @params);
        void GetQueryObjecti64v(uint @id, GlQueryObjectParameterName @pname, long[] @params);
        void GetQueryObjecti64vEXT(uint @id, GlQueryObjectParameterName @pname, long[] @params);
        void GetQueryObjectiv(uint @id, GlQueryObjectParameterName @pname, int[] @params);
        void GetQueryObjectivARB(uint @id, GlQueryObjectParameterName @pname, int[] @params);
        void GetQueryObjectivEXT(uint @id, GlQueryObjectParameterName @pname, int[] @params);
        void GetQueryObjectui64v(uint @id, GlQueryObjectParameterName @pname, ulong[] @params);
        void GetQueryObjectui64vEXT(uint @id, GlQueryObjectParameterName @pname, ulong[] @params);
        void GetQueryObjectuiv(uint @id, GlQueryObjectParameterName @pname, uint[] @params);
        void GetQueryObjectuivARB(uint @id, GlQueryObjectParameterName @pname, uint[] @params);
        void GetQueryObjectuivEXT(uint @id, GlQueryObjectParameterName @pname, uint[] @params);
        void GetQueryiv(GlQueryTarget @target, GlQueryParameterName @pname, int[] @params);
        void GetQueryivARB(GlQueryTarget @target, GlQueryParameterName @pname, int[] @params);
        void GetQueryivEXT(GlQueryTarget @target, GlQueryParameterName @pname, int[] @params);
        void GetRenderbufferParameteriv(GlRenderbufferTarget @target, GlRenderbufferParameterName @pname, int[] @params);
        void GetRenderbufferParameterivEXT(GlRenderbufferTarget @target, GlRenderbufferParameterName @pname, int[] @params);
        void GetRenderbufferParameterivOES(GlRenderbufferTarget @target, GlRenderbufferParameterName @pname, int[] @params);
        void GetSamplerParameterIiv(uint @sampler, GlSamplerParameterName @pname, int[] @params);
        void GetSamplerParameterIivEXT(uint @sampler, GlSamplerParameterName @pname, int[] @params);
        void GetSamplerParameterIivOES(uint @sampler, GlSamplerParameterName @pname, int[] @params);
        void GetSamplerParameterIuiv(uint @sampler, GlSamplerParameterName @pname, uint[] @params);
        void GetSamplerParameterIuivEXT(uint @sampler, GlSamplerParameterName @pname, uint[] @params);
        void GetSamplerParameterIuivOES(uint @sampler, GlSamplerParameterName @pname, uint[] @params);
        void GetSamplerParameterfv(uint @sampler, GlSamplerParameterName @pname, float[] @params);
        void GetSamplerParameteriv(uint @sampler, GlSamplerParameterName @pname, int[] @params);
        void GetSemaphoreParameterui64vEXT(uint @semaphore, GlSemaphoreParameterName @pname, ulong[] @params);
        void GetSeparableFilter(GlSeparableTargetEXT @target, GlPixelFormat @format, GlPixelType @type, byte[] @row, byte[] @column, byte[] @span);
        void GetSeparableFilterEXT(GlSeparableTargetEXT @target, GlPixelFormat @format, GlPixelType @type, byte[] @row, byte[] @column, byte[] @span);
        void GetShaderInfoLog(uint @shader, int @bufSize, int[] @length, byte[] @infoLog);
        void GetShaderPrecisionFormat(GlShaderType @shadertype, GlPrecisionType @precisiontype, int[] @range, int[] @precision);
        void GetShaderSource(uint @shader, int @bufSize, int[] @length, byte[] @source);
        void GetShaderSourceARB(IntPtr @obj, int @maxLength, int[] @length, byte[] @source);
        void GetShaderiv(uint @shader, GlShaderParameterName @pname, int[] @params);
        void GetSharpenTexFuncSGIS(GlTextureTarget @target, float[] @points);
        ushort GetStageIndexNV(GlShaderType @shadertype);
        byte GetString(GlStringName @name);
        byte GetStringi(GlStringName @name, uint @index);
        uint GetSubroutineIndex(uint @program, GlShaderType @shadertype, byte[] @name);
        int GetSubroutineUniformLocation(uint @program, GlShaderType @shadertype, byte[] @name);
        void GetSynciv(IntPtr @sync, GlSyncParameterName @pname, int @bufSize, int[] @length, int[] @values);
        void GetSyncivAPPLE(IntPtr @sync, GlSyncParameterName @pname, int @bufSize, int[] @length, int[] @values);
        void GetTexBumpParameterfvATI(uint @pname, float[] @param);
        void GetTexBumpParameterivATI(uint @pname, int[] @param);
        void GetTexEnvfv(GlTextureEnvTarget @target, GlTextureEnvParameter @pname, float[] @params);
        void GetTexEnviv(GlTextureEnvTarget @target, GlTextureEnvParameter @pname, int[] @params);
        void GetTexEnvxv(GlTextureEnvTarget @target, GlTextureEnvParameter @pname, int[] @params);
        void GetTexEnvxvOES(GlTextureEnvTarget @target, GlTextureEnvParameter @pname, int[] @params);
        void GetTexFilterFuncSGIS(GlTextureTarget @target, uint @filter, float[] @weights);
        void GetTexGendv(GlTextureCoordName @coord, GlTextureGenParameter @pname, double[] @params);
        void GetTexGenfv(GlTextureCoordName @coord, GlTextureGenParameter @pname, float[] @params);
        void GetTexGenfvOES(GlTextureCoordName @coord, GlTextureGenParameter @pname, float[] @params);
        void GetTexGeniv(GlTextureCoordName @coord, GlTextureGenParameter @pname, int[] @params);
        void GetTexGenivOES(GlTextureCoordName @coord, GlTextureGenParameter @pname, int[] @params);
        void GetTexGenxvOES(GlTextureCoordName @coord, GlTextureGenParameter @pname, int[] @params);
        void GetTexImage(GlTextureTarget @target, int @level, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void GetTexLevelParameterfv(GlTextureTarget @target, int @level, GlGetTextureParameter @pname, float[] @params);
        void GetTexLevelParameteriv(GlTextureTarget @target, int @level, GlGetTextureParameter @pname, int[] @params);
        void GetTexLevelParameterxvOES(GlTextureTarget @target, int @level, GlGetTextureParameter @pname, int[] @params);
        void GetTexParameterIiv(GlTextureTarget @target, GlGetTextureParameter @pname, int[] @params);
        void GetTexParameterIivEXT(GlTextureTarget @target, GlGetTextureParameter @pname, int[] @params);
        void GetTexParameterIivOES(GlTextureTarget @target, GlGetTextureParameter @pname, int[] @params);
        void GetTexParameterIuiv(GlTextureTarget @target, GlGetTextureParameter @pname, uint[] @params);
        void GetTexParameterIuivEXT(GlTextureTarget @target, GlGetTextureParameter @pname, uint[] @params);
        void GetTexParameterIuivOES(GlTextureTarget @target, GlGetTextureParameter @pname, uint[] @params);
        void GetTexParameterPointervAPPLE(uint @target, uint @pname, byte[][] @params);
        void GetTexParameterfv(GlTextureTarget @target, GlGetTextureParameter @pname, float[] @params);
        void GetTexParameteriv(GlTextureTarget @target, GlGetTextureParameter @pname, int[] @params);
        void GetTexParameterxv(GlTextureTarget @target, GlGetTextureParameter @pname, int[] @params);
        void GetTexParameterxvOES(GlTextureTarget @target, GlGetTextureParameter @pname, int[] @params);
        ulong GetTextureHandleARB(uint @texture);
        ulong GetTextureHandleIMG(uint @texture);
        ulong GetTextureHandleNV(uint @texture);
        void GetTextureImage(uint @texture, int @level, GlPixelFormat @format, GlPixelType @type, int @bufSize, byte[] @pixels);
        void GetTextureImageEXT(uint @texture, GlTextureTarget @target, int @level, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void GetTextureLevelParameterfv(uint @texture, int @level, GlGetTextureParameter @pname, float[] @params);
        void GetTextureLevelParameterfvEXT(uint @texture, GlTextureTarget @target, int @level, GlGetTextureParameter @pname, float[] @params);
        void GetTextureLevelParameteriv(uint @texture, int @level, GlGetTextureParameter @pname, int[] @params);
        void GetTextureLevelParameterivEXT(uint @texture, GlTextureTarget @target, int @level, GlGetTextureParameter @pname, int[] @params);
        void GetTextureParameterIiv(uint @texture, GlGetTextureParameter @pname, int[] @params);
        void GetTextureParameterIivEXT(uint @texture, GlTextureTarget @target, GlGetTextureParameter @pname, int[] @params);
        void GetTextureParameterIuiv(uint @texture, GlGetTextureParameter @pname, uint[] @params);
        void GetTextureParameterIuivEXT(uint @texture, GlTextureTarget @target, GlGetTextureParameter @pname, uint[] @params);
        void GetTextureParameterfv(uint @texture, GlGetTextureParameter @pname, float[] @params);
        void GetTextureParameterfvEXT(uint @texture, GlTextureTarget @target, GlGetTextureParameter @pname, float[] @params);
        void GetTextureParameteriv(uint @texture, GlGetTextureParameter @pname, int[] @params);
        void GetTextureParameterivEXT(uint @texture, GlTextureTarget @target, GlGetTextureParameter @pname, int[] @params);
        ulong GetTextureSamplerHandleARB(uint @texture, uint @sampler);
        ulong GetTextureSamplerHandleIMG(uint @texture, uint @sampler);
        ulong GetTextureSamplerHandleNV(uint @texture, uint @sampler);
        void GetTextureSubImage(uint @texture, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, GlPixelFormat @format, GlPixelType @type, int @bufSize, byte[] @pixels);
        void GetTrackMatrixivNV(uint @target, uint @address, uint @pname, int[] @params);
        void GetTransformFeedbackVarying(uint @program, uint @index, int @bufSize, int[] @length, int[] @size, uint[] @type, byte[] @name);
        void GetTransformFeedbackVaryingEXT(uint @program, uint @index, int @bufSize, int[] @length, int[] @size, uint[] @type, byte[] @name);
        void GetTransformFeedbackVaryingNV(uint @program, uint @index, int[] @location);
        void GetTransformFeedbacki64_v(uint @xfb, GlTransformFeedbackPName @pname, uint @index, long[] @param);
        void GetTransformFeedbacki_v(uint @xfb, GlTransformFeedbackPName @pname, uint @index, int[] @param);
        void GetTransformFeedbackiv(uint @xfb, GlTransformFeedbackPName @pname, int[] @param);
        void GetTranslatedShaderSourceANGLE(uint @shader, int @bufsize, int[] @length, byte[] @source);
        uint GetUniformBlockIndex(uint @program, byte[] @uniformBlockName);
        int GetUniformBufferSizeEXT(uint @program, int @location);
        void GetUniformIndices(uint @program, int @uniformCount, byte[][] @uniformNames, uint[] @uniformIndices);
        int GetUniformLocation(uint @program, byte[] @name);
        int GetUniformLocationARB(IntPtr @programObj, byte[] @name);
        long GetUniformOffsetEXT(uint @program, int @location);
        void GetUniformSubroutineuiv(GlShaderType @shadertype, int @location, uint[] @params);
        void GetUniformdv(uint @program, int @location, double[] @params);
        void GetUniformfv(uint @program, int @location, float[] @params);
        void GetUniformfvARB(IntPtr @programObj, int @location, float[] @params);
        void GetUniformi64vARB(uint @program, int @location, long[] @params);
        void GetUniformi64vNV(uint @program, int @location, long[] @params);
        void GetUniformiv(uint @program, int @location, int[] @params);
        void GetUniformivARB(IntPtr @programObj, int @location, int[] @params);
        void GetUniformui64vARB(uint @program, int @location, ulong[] @params);
        void GetUniformui64vNV(uint @program, int @location, ulong[] @params);
        void GetUniformuiv(uint @program, int @location, uint[] @params);
        void GetUniformuivEXT(uint @program, int @location, uint[] @params);
        void GetUnsignedBytevEXT(GlGetPName @pname, byte[] @data);
        void GetUnsignedBytei_vEXT(uint @target, uint @index, byte[] @data);
        void GetVariantArrayObjectfvATI(uint @id, uint @pname, float[] @params);
        void GetVariantArrayObjectivATI(uint @id, uint @pname, int[] @params);
        void GetVariantBooleanvEXT(uint @id, uint @value, GlBoolean[] @data);
        void GetVariantFloatvEXT(uint @id, uint @value, float[] @data);
        void GetVariantIntegervEXT(uint @id, uint @value, int[] @data);
        void GetVariantPointervEXT(uint @id, uint @value, byte[][] @data);
        int GetVaryingLocationNV(uint @program, byte[] @name);
        void GetVertexArrayIndexed64iv(uint @vaobj, uint @index, GlVertexArrayPName @pname, long[] @param);
        void GetVertexArrayIndexediv(uint @vaobj, uint @index, GlVertexArrayPName @pname, int[] @param);
        void GetVertexArrayIntegeri_vEXT(uint @vaobj, uint @index, GlVertexArrayPName @pname, int[] @param);
        void GetVertexArrayIntegervEXT(uint @vaobj, GlVertexArrayPName @pname, int[] @param);
        void GetVertexArrayPointeri_vEXT(uint @vaobj, uint @index, GlVertexArrayPName @pname, byte[][] @param);
        void GetVertexArrayPointervEXT(uint @vaobj, GlVertexArrayPName @pname, byte[][] @param);
        void GetVertexArrayiv(uint @vaobj, GlVertexArrayPName @pname, int[] @param);
        void GetVertexAttribArrayObjectfvATI(uint @index, uint @pname, float[] @params);
        void GetVertexAttribArrayObjectivATI(uint @index, uint @pname, int[] @params);
        void GetVertexAttribIiv(uint @index, GlVertexAttribEnum @pname, int[] @params);
        void GetVertexAttribIivEXT(uint @index, GlVertexAttribEnum @pname, int[] @params);
        void GetVertexAttribIuiv(uint @index, GlVertexAttribEnum @pname, uint[] @params);
        void GetVertexAttribIuivEXT(uint @index, GlVertexAttribEnum @pname, uint[] @params);
        void GetVertexAttribLdv(uint @index, GlVertexAttribEnum @pname, double[] @params);
        void GetVertexAttribLdvEXT(uint @index, GlVertexAttribEnum @pname, double[] @params);
        void GetVertexAttribLi64vNV(uint @index, GlVertexAttribEnum @pname, long[] @params);
        void GetVertexAttribLui64vARB(uint @index, GlVertexAttribEnum @pname, ulong[] @params);
        void GetVertexAttribLui64vNV(uint @index, GlVertexAttribEnum @pname, ulong[] @params);
        void GetVertexAttribPointerv(uint @index, uint @pname, byte[][] @pointer);
        void GetVertexAttribPointervARB(uint @index, uint @pname, byte[][] @pointer);
        void GetVertexAttribPointervNV(uint @index, uint @pname, byte[][] @pointer);
        void GetVertexAttribdv(uint @index, uint @pname, double[] @params);
        void GetVertexAttribdvARB(uint @index, uint @pname, double[] @params);
        void GetVertexAttribdvNV(uint @index, uint @pname, double[] @params);
        void GetVertexAttribfv(uint @index, uint @pname, float[] @params);
        void GetVertexAttribfvARB(uint @index, uint @pname, float[] @params);
        void GetVertexAttribfvNV(uint @index, uint @pname, float[] @params);
        void GetVertexAttribiv(uint @index, uint @pname, int[] @params);
        void GetVertexAttribivARB(uint @index, uint @pname, int[] @params);
        void GetVertexAttribivNV(uint @index, uint @pname, int[] @params);
        void GetVideoCaptureStreamdvNV(uint @video_capture_slot, uint @stream, uint @pname, double[] @params);
        void GetVideoCaptureStreamfvNV(uint @video_capture_slot, uint @stream, uint @pname, float[] @params);
        void GetVideoCaptureStreamivNV(uint @video_capture_slot, uint @stream, uint @pname, int[] @params);
        void GetVideoCaptureivNV(uint @video_capture_slot, uint @pname, int[] @params);
        void GetVideoi64vNV(uint @video_slot, uint @pname, long[] @params);
        void GetVideoivNV(uint @video_slot, uint @pname, int[] @params);
        void GetVideoui64vNV(uint @video_slot, uint @pname, ulong[] @params);
        void GetVideouivNV(uint @video_slot, uint @pname, uint[] @params);
        void GetnColorTable(GlColorTableTarget @target, GlPixelFormat @format, GlPixelType @type, int @bufSize, byte[] @table);
        void GetnColorTableARB(GlColorTableTarget @target, GlPixelFormat @format, GlPixelType @type, int @bufSize, byte[] @table);
        void GetnCompressedTexImage(GlTextureTarget @target, int @lod, int @bufSize, byte[] @pixels);
        void GetnCompressedTexImageARB(GlTextureTarget @target, int @lod, int @bufSize, byte[] @img);
        void GetnConvolutionFilter(GlConvolutionTarget @target, GlPixelFormat @format, GlPixelType @type, int @bufSize, byte[] @image);
        void GetnConvolutionFilterARB(GlConvolutionTarget @target, GlPixelFormat @format, GlPixelType @type, int @bufSize, byte[] @image);
        void GetnHistogram(GlHistogramTargetEXT @target, bool @reset, GlPixelFormat @format, GlPixelType @type, int @bufSize, byte[] @values);
        void GetnHistogramARB(GlHistogramTargetEXT @target, GlBoolean @reset, GlPixelFormat @format, GlPixelType @type, int @bufSize, byte[] @values);
        void GetnMapdv(GlMapTarget @target, GlMapQuery @query, int @bufSize, double[] @v);
        void GetnMapdvARB(GlMapTarget @target, GlMapQuery @query, int @bufSize, double[] @v);
        void GetnMapfv(GlMapTarget @target, GlMapQuery @query, int @bufSize, float[] @v);
        void GetnMapfvARB(GlMapTarget @target, GlMapQuery @query, int @bufSize, float[] @v);
        void GetnMapiv(GlMapTarget @target, GlMapQuery @query, int @bufSize, int[] @v);
        void GetnMapivARB(GlMapTarget @target, GlMapQuery @query, int @bufSize, int[] @v);
        void GetnMinmax(GlMinmaxTargetEXT @target, bool @reset, GlPixelFormat @format, GlPixelType @type, int @bufSize, byte[] @values);
        void GetnMinmaxARB(GlMinmaxTargetEXT @target, GlBoolean @reset, GlPixelFormat @format, GlPixelType @type, int @bufSize, byte[] @values);
        void GetnPixelMapfv(GlPixelMap @map, int @bufSize, float[] @values);
        void GetnPixelMapfvARB(GlPixelMap @map, int @bufSize, float[] @values);
        void GetnPixelMapuiv(GlPixelMap @map, int @bufSize, uint[] @values);
        void GetnPixelMapuivARB(GlPixelMap @map, int @bufSize, uint[] @values);
        void GetnPixelMapusv(GlPixelMap @map, int @bufSize, ushort[] @values);
        void GetnPixelMapusvARB(GlPixelMap @map, int @bufSize, ushort[] @values);
        void GetnPolygonStipple(int @bufSize, byte[] @pattern);
        void GetnPolygonStippleARB(int @bufSize, byte[] @pattern);
        void GetnSeparableFilter(GlSeparableTargetEXT @target, GlPixelFormat @format, GlPixelType @type, int @rowBufSize, byte[] @row, int @columnBufSize, byte[] @column, byte[] @span);
        void GetnSeparableFilterARB(GlSeparableTargetEXT @target, GlPixelFormat @format, GlPixelType @type, int @rowBufSize, byte[] @row, int @columnBufSize, byte[] @column, byte[] @span);
        void GetnTexImage(GlTextureTarget @target, int @level, GlPixelFormat @format, GlPixelType @type, int @bufSize, byte[] @pixels);
        void GetnTexImageARB(GlTextureTarget @target, int @level, GlPixelFormat @format, GlPixelType @type, int @bufSize, byte[] @img);
        void GetnUniformdv(uint @program, int @location, int @bufSize, double[] @params);
        void GetnUniformdvARB(uint @program, int @location, int @bufSize, double[] @params);
        void GetnUniformfv(uint @program, int @location, int @bufSize, float[] @params);
        void GetnUniformfvARB(uint @program, int @location, int @bufSize, float[] @params);
        void GetnUniformfvEXT(uint @program, int @location, int @bufSize, float[] @params);
        void GetnUniformfvKHR(uint @program, int @location, int @bufSize, float[] @params);
        void GetnUniformi64vARB(uint @program, int @location, int @bufSize, long[] @params);
        void GetnUniformiv(uint @program, int @location, int @bufSize, int[] @params);
        void GetnUniformivARB(uint @program, int @location, int @bufSize, int[] @params);
        void GetnUniformivEXT(uint @program, int @location, int @bufSize, int[] @params);
        void GetnUniformivKHR(uint @program, int @location, int @bufSize, int[] @params);
        void GetnUniformui64vARB(uint @program, int @location, int @bufSize, ulong[] @params);
        void GetnUniformuiv(uint @program, int @location, int @bufSize, uint[] @params);
        void GetnUniformuivARB(uint @program, int @location, int @bufSize, uint[] @params);
        void GetnUniformuivKHR(uint @program, int @location, int @bufSize, uint[] @params);
        void GlobalAlphaFactorbSUN(sbyte @factor);
        void GlobalAlphaFactordSUN(double @factor);
        void GlobalAlphaFactorfSUN(float @factor);
        void GlobalAlphaFactoriSUN(int @factor);
        void GlobalAlphaFactorsSUN(short @factor);
        void GlobalAlphaFactorubSUN(byte @factor);
        void GlobalAlphaFactoruiSUN(uint @factor);
        void GlobalAlphaFactorusSUN(ushort @factor);
        void Hint(GlHintTarget @target, GlHintMode @mode);
        void HintPGI(uint @target, int @mode);
        void Histogram(GlHistogramTargetEXT @target, int @width, GlInternalFormat @internalformat, GlBoolean @sink);
        void HistogramEXT(GlHistogramTargetEXT @target, int @width, GlInternalFormat @internalformat, GlBoolean @sink);
        void IglooInterfaceSGIX(uint @pname, byte[] @params);
        void ImageTransformParameterfHP(uint @target, uint @pname, float @param);
        void ImageTransformParameterfvHP(uint @target, uint @pname, float[] @params);
        void ImageTransformParameteriHP(uint @target, uint @pname, int @param);
        void ImageTransformParameterivHP(uint @target, uint @pname, int[] @params);
        void ImportMemoryFdEXT(uint @memory, ulong @size, GlExternalHandleType @handleType, int @fd);
        void ImportMemoryWin32HandleEXT(uint @memory, ulong @size, GlExternalHandleType @handleType, byte[] @handle);
        void ImportMemoryWin32NameEXT(uint @memory, ulong @size, GlExternalHandleType @handleType, byte[] @name);
        void ImportSemaphoreFdEXT(uint @semaphore, GlExternalHandleType @handleType, int @fd);
        void ImportSemaphoreWin32HandleEXT(uint @semaphore, GlExternalHandleType @handleType, byte[] @handle);
        void ImportSemaphoreWin32NameEXT(uint @semaphore, GlExternalHandleType @handleType, byte[] @name);
        IntPtr ImportSyncEXT(uint @external_sync_type, long @external_sync, uint @flags);
        void IndexFormatNV(uint @type, int @stride);
        void IndexFuncEXT(uint @func, float @ref);
        void IndexMask(uint @mask);
        void IndexMaterialEXT(GlMaterialFace @face, uint @mode);
        void IndexPointer(GlIndexPointerType @type, int @stride, byte[] @pointer);
        void IndexPointerEXT(GlIndexPointerType @type, int @stride, int @count, byte[] @pointer);
        void IndexPointerListIBM(GlIndexPointerType @type, int @stride, byte[][] @pointer, int @ptrstride);
        void Indexd(double @c);
        void Indexdv(double[] @c);
        void Indexf(float @c);
        void Indexfv(float[] @c);
        void Indexi(int @c);
        void Indexiv(int[] @c);
        void Indexs(short @c);
        void Indexsv(short[] @c);
        void Indexub(byte @c);
        void Indexubv(byte[] @c);
        void IndexxOES(int @component);
        void IndexxvOES(int[] @component);
        void InitNames();
        void InsertComponentEXT(uint @res, uint @src, uint @num);
        void InsertEventMarkerEXT(int @length, byte[] @marker);
        void InstrumentsBufferSGIX(int @size, int[] @buffer);
        void InterleavedArrays(GlInterleavedArrayFormat @format, int @stride, byte[] @pointer);
        void InterpolatePathsNV(uint @resultPath, uint @pathA, uint @pathB, float @weight);
        void InvalidateBufferData(uint @buffer);
        void InvalidateBufferSubData(uint @buffer, long @offset, long @length);
        void InvalidateFramebuffer(GlFramebufferTarget @target, int @numAttachments, uint[] @attachments);
        void InvalidateNamedFramebufferData(uint @framebuffer, int @numAttachments, GlFramebufferAttachment[] @attachments);
        void InvalidateNamedFramebufferSubData(uint @framebuffer, int @numAttachments, GlFramebufferAttachment[] @attachments, int @x, int @y, int @width, int @height);
        void InvalidateSubFramebuffer(uint @target, int @numAttachments, GlFramebufferAttachment[] @attachments, int @x, int @y, int @width, int @height);
        void InvalidateTexImage(uint @texture, int @level);
        void InvalidateTexSubImage(uint @texture, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth);
        bool IsAsyncMarkerSGIX(uint @marker);
        bool IsBuffer(uint @buffer);
        bool IsBufferARB(uint @buffer);
        bool IsBufferResidentNV(uint @target);
        bool IsCommandListNV(uint @list);
        bool IsEnabled(GlEnableCap @cap);
        bool IsEnabledIndexedEXT(GlEnableCap @target, uint @index);
        bool IsEnabledi(GlEnableCap @target, uint @index);
        bool IsEnablediEXT(GlEnableCap @target, uint @index);
        bool IsEnablediNV(GlEnableCap @target, uint @index);
        bool IsEnablediOES(GlEnableCap @target, uint @index);
        bool IsFenceAPPLE(uint @fence);
        bool IsFenceNV(uint @fence);
        bool IsFramebuffer(uint @framebuffer);
        bool IsFramebufferEXT(uint @framebuffer);
        bool IsFramebufferOES(uint @framebuffer);
        bool IsImageHandleResidentARB(ulong @handle);
        bool IsImageHandleResidentNV(ulong @handle);
        bool IsList(uint @list);
        bool IsMemoryObjectEXT(uint @memoryObject);
        bool IsNameAMD(uint @identifier, uint @name);
        bool IsNamedBufferResidentNV(uint @buffer);
        bool IsNamedStringARB(int @namelen, byte[] @name);
        bool IsObjectBufferATI(uint @buffer);
        bool IsOcclusionQueryNV(uint @id);
        bool IsPathNV(uint @path);
        bool IsPointInFillPathNV(uint @path, uint @mask, float @x, float @y);
        bool IsPointInStrokePathNV(uint @path, float @x, float @y);
        bool IsProgram(uint @program);
        bool IsProgramARB(uint @program);
        bool IsProgramNV(uint @id);
        bool IsProgramPipeline(uint @pipeline);
        bool IsProgramPipelineEXT(uint @pipeline);
        bool IsQuery(uint @id);
        bool IsQueryARB(uint @id);
        bool IsQueryEXT(uint @id);
        bool IsRenderbuffer(uint @renderbuffer);
        bool IsRenderbufferEXT(uint @renderbuffer);
        bool IsRenderbufferOES(uint @renderbuffer);
        bool IsSemaphoreEXT(uint @semaphore);
        bool IsSampler(uint @sampler);
        bool IsShader(uint @shader);
        bool IsStateNV(uint @state);
        bool IsSync(IntPtr @sync);
        bool IsSyncAPPLE(IntPtr @sync);
        bool IsTexture(uint @texture);
        bool IsTextureEXT(uint @texture);
        bool IsTextureHandleResidentARB(ulong @handle);
        bool IsTextureHandleResidentNV(ulong @handle);
        bool IsTransformFeedback(uint @id);
        bool IsTransformFeedbackNV(uint @id);
        bool IsVariantEnabledEXT(uint @id, uint @cap);
        bool IsVertexArray(uint @array);
        bool IsVertexArrayAPPLE(uint @array);
        bool IsVertexArrayOES(uint @array);
        bool IsVertexAttribEnabledAPPLE(uint @index, uint @pname);
        void LGPUCopyImageSubDataNVX(uint @sourceGpu, uint @destinationGpuMask, uint @srcName, uint @srcTarget, int @srcLevel, int @srcX, int @srxY, int @srcZ, uint @dstName, uint @dstTarget, int @dstLevel, int @dstX, int @dstY, int @dstZ, int @width, int @height, int @depth);
        void LGPUInterlockNVX();
        void LGPUNamedBufferSubDataNVX(uint @gpuMask, uint @buffer, long @offset, long @size, byte[] @data);
        void LabelObjectEXT(uint @type, uint @object, int @length, byte[] @label);
        void LightEnviSGIX(GlLightEnvParameterSGIX @pname, int @param);
        void LightModelf(GlLightModelParameter @pname, float @param);
        void LightModelfv(GlLightModelParameter @pname, float[] @params);
        void LightModeli(GlLightModelParameter @pname, int @param);
        void LightModeliv(GlLightModelParameter @pname, int[] @params);
        void LightModelx(GlLightModelParameter @pname, int @param);
        void LightModelxOES(GlLightModelParameter @pname, int @param);
        void LightModelxv(GlLightModelParameter @pname, int[] @param);
        void LightModelxvOES(GlLightModelParameter @pname, int[] @param);
        void Lightf(GlLightName @light, GlLightParameter @pname, float @param);
        void Lightfv(GlLightName @light, GlLightParameter @pname, float[] @params);
        void Lighti(GlLightName @light, GlLightParameter @pname, int @param);
        void Lightiv(GlLightName @light, GlLightParameter @pname, int[] @params);
        void Lightx(GlLightName @light, GlLightParameter @pname, int @param);
        void LightxOES(GlLightName @light, GlLightParameter @pname, int @param);
        void Lightxv(GlLightName @light, GlLightParameter @pname, int[] @params);
        void LightxvOES(GlLightName @light, GlLightParameter @pname, int[] @params);
        void LineStipple(int @factor, ushort @pattern);
        void LineWidth(float @width);
        void LineWidthx(int @width);
        void LineWidthxOES(int @width);
        void LinkProgram(uint @program);
        void LinkProgramARB(IntPtr @programObj);
        void ListBase(uint @base);
        void ListDrawCommandsStatesClientNV(uint @list, uint @segment, byte[][] @indirects, int[] @sizes, uint[] @states, uint[] @fbos, uint @count);
        void ListParameterfSGIX(uint @list, GlListParameterName @pname, float @param);
        void ListParameterfvSGIX(uint @list, GlListParameterName @pname, float[] @params);
        void ListParameteriSGIX(uint @list, GlListParameterName @pname, int @param);
        void ListParameterivSGIX(uint @list, GlListParameterName @pname, int[] @params);
        void LoadIdentity();
        void LoadIdentityDeformationMapSGIX(GlFfdMaskSGIX @mask);
        void LoadMatrixd(double[] @m);
        void LoadMatrixf(float[] @m);
        void LoadMatrixx(int[] @m);
        void LoadMatrixxOES(int[] @m);
        void LoadName(uint @name);
        void LoadPaletteFromModelViewMatrixOES();
        void LoadProgramNV(uint @target, uint @id, int @len, byte[] @program);
        void LoadTransposeMatrixd(double[] @m);
        void LoadTransposeMatrixdARB(double[] @m);
        void LoadTransposeMatrixf(float[] @m);
        void LoadTransposeMatrixfARB(float[] @m);
        void LoadTransposeMatrixxOES(int[] @m);
        void LockArraysEXT(int @first, int @count);
        void LogicOp(GlLogicOp @opcode);
        void MakeBufferNonResidentNV(uint @target);
        void MakeBufferResidentNV(uint @target, uint @access);
        void MakeImageHandleNonResidentARB(ulong @handle);
        void MakeImageHandleNonResidentNV(ulong @handle);
        void MakeImageHandleResidentARB(ulong @handle, uint @access);
        void MakeImageHandleResidentNV(ulong @handle, uint @access);
        void MakeNamedBufferNonResidentNV(uint @buffer);
        void MakeNamedBufferResidentNV(uint @buffer, uint @access);
        void MakeTextureHandleNonResidentARB(ulong @handle);
        void MakeTextureHandleNonResidentNV(ulong @handle);
        void MakeTextureHandleResidentARB(ulong @handle);
        void MakeTextureHandleResidentNV(ulong @handle);
        void Map1d(GlMapTarget @target, double @u1, double @u2, int @stride, int @order, double[] @points);
        void Map1f(GlMapTarget @target, float @u1, float @u2, int @stride, int @order, float[] @points);
        void Map1xOES(GlMapTarget @target, int @u1, int @u2, int @stride, int @order, int @points);
        void Map2d(GlMapTarget @target, double @u1, double @u2, int @ustride, int @uorder, double @v1, double @v2, int @vstride, int @vorder, double[] @points);
        void Map2f(GlMapTarget @target, float @u1, float @u2, int @ustride, int @uorder, float @v1, float @v2, int @vstride, int @vorder, float[] @points);
        void Map2xOES(GlMapTarget @target, int @u1, int @u2, int @ustride, int @uorder, int @v1, int @v2, int @vstride, int @vorder, int @points);
        IntPtr MapBuffer(GlBufferTargetARB @target, GlBufferAccessARB @access);
        IntPtr MapBufferARB(GlBufferTargetARB @target, GlBufferAccessARB @access);
        IntPtr MapBufferOES(GlBufferTargetARB @target, GlBufferAccessARB @access);
        IntPtr MapBufferRange(GlBufferTargetARB @target, long @offset, long @length, GlBufferAccessMask @access);
        IntPtr MapBufferRangeEXT(GlBufferTargetARB @target, long @offset, long @length, GlBufferAccessMask @access);
        void MapControlPointsNV(uint @target, uint @index, uint @type, int @ustride, int @vstride, int @uorder, int @vorder, GlBoolean @packed, byte[] @points);
        void MapGrid1d(int @un, double @u1, double @u2);
        void MapGrid1f(int @un, float @u1, float @u2);
        void MapGrid1xOES(int @n, int @u1, int @u2);
        void MapGrid2d(int @un, double @u1, double @u2, int @vn, double @v1, double @v2);
        void MapGrid2f(int @un, float @u1, float @u2, int @vn, float @v1, float @v2);
        void MapGrid2xOES(int @n, int @u1, int @u2, int @v1, int @v2);
        IntPtr MapNamedBuffer(uint @buffer, GlBufferAccessARB @access);
        IntPtr MapNamedBufferEXT(uint @buffer, GlBufferAccessARB @access);
        IntPtr MapNamedBufferRange(uint @buffer, long @offset, long @length, GlBufferAccessMask @access);
        IntPtr MapNamedBufferRangeEXT(uint @buffer, long @offset, long @length, GlBufferAccessMask @access);
        IntPtr MapObjectBufferATI(uint @buffer);
        void MapParameterfvNV(uint @target, uint @pname, float[] @params);
        void MapParameterivNV(uint @target, uint @pname, int[] @params);
        IntPtr MapTexture2DINTEL(uint @texture, int @level, uint @access, int[] @stride, uint[] @layout);
        void MapVertexAttrib1dAPPLE(uint @index, uint @size, double @u1, double @u2, int @stride, int @order, double[] @points);
        void MapVertexAttrib1fAPPLE(uint @index, uint @size, float @u1, float @u2, int @stride, int @order, float[] @points);
        void MapVertexAttrib2dAPPLE(uint @index, uint @size, double @u1, double @u2, int @ustride, int @uorder, double @v1, double @v2, int @vstride, int @vorder, double[] @points);
        void MapVertexAttrib2fAPPLE(uint @index, uint @size, float @u1, float @u2, int @ustride, int @uorder, float @v1, float @v2, int @vstride, int @vorder, float[] @points);
        void Materialf(GlMaterialFace @face, GlMaterialParameter @pname, float @param);
        void Materialfv(GlMaterialFace @face, GlMaterialParameter @pname, float[] @params);
        void Materiali(GlMaterialFace @face, GlMaterialParameter @pname, int @param);
        void Materialiv(GlMaterialFace @face, GlMaterialParameter @pname, int[] @params);
        void Materialx(GlMaterialFace @face, GlMaterialParameter @pname, int @param);
        void MaterialxOES(GlMaterialFace @face, GlMaterialParameter @pname, int @param);
        void Materialxv(GlMaterialFace @face, GlMaterialParameter @pname, int[] @param);
        void MaterialxvOES(GlMaterialFace @face, GlMaterialParameter @pname, int[] @param);
        void MatrixFrustumEXT(GlMatrixMode @mode, double @left, double @right, double @bottom, double @top, double @zNear, double @zFar);
        void MatrixIndexPointerARB(int @size, uint @type, int @stride, byte[] @pointer);
        void MatrixIndexPointerOES(int @size, uint @type, int @stride, byte[] @pointer);
        void MatrixIndexubvARB(int @size, byte[] @indices);
        void MatrixIndexuivARB(int @size, uint[] @indices);
        void MatrixIndexusvARB(int @size, ushort[] @indices);
        void MatrixLoad3x2fNV(uint @matrixMode, float[] @m);
        void MatrixLoad3x3fNV(uint @matrixMode, float[] @m);
        void MatrixLoadIdentityEXT(GlMatrixMode @mode);
        void MatrixLoadTranspose3x3fNV(uint @matrixMode, float[] @m);
        void MatrixLoadTransposedEXT(GlMatrixMode @mode, double[] @m);
        void MatrixLoadTransposefEXT(GlMatrixMode @mode, float[] @m);
        void MatrixLoaddEXT(GlMatrixMode @mode, double[] @m);
        void MatrixLoadfEXT(GlMatrixMode @mode, float[] @m);
        void MatrixMode(GlMatrixMode @mode);
        void MatrixMult3x2fNV(uint @matrixMode, float[] @m);
        void MatrixMult3x3fNV(uint @matrixMode, float[] @m);
        void MatrixMultTranspose3x3fNV(uint @matrixMode, float[] @m);
        void MatrixMultTransposedEXT(GlMatrixMode @mode, double[] @m);
        void MatrixMultTransposefEXT(GlMatrixMode @mode, float[] @m);
        void MatrixMultdEXT(GlMatrixMode @mode, double[] @m);
        void MatrixMultfEXT(GlMatrixMode @mode, float[] @m);
        void MatrixOrthoEXT(GlMatrixMode @mode, double @left, double @right, double @bottom, double @top, double @zNear, double @zFar);
        void MatrixPopEXT(GlMatrixMode @mode);
        void MatrixPushEXT(GlMatrixMode @mode);
        void MatrixRotatedEXT(GlMatrixMode @mode, double @angle, double @x, double @y, double @z);
        void MatrixRotatefEXT(GlMatrixMode @mode, float @angle, float @x, float @y, float @z);
        void MatrixScaledEXT(GlMatrixMode @mode, double @x, double @y, double @z);
        void MatrixScalefEXT(GlMatrixMode @mode, float @x, float @y, float @z);
        void MatrixTranslatedEXT(GlMatrixMode @mode, double @x, double @y, double @z);
        void MatrixTranslatefEXT(GlMatrixMode @mode, float @x, float @y, float @z);
        void MaxShaderCompilerThreadsKHR(uint @count);
        void MaxShaderCompilerThreadsARB(uint @count);
        void MemoryBarrier(GlMemoryBarrierMask @barriers);
        void MemoryBarrierByRegion(GlMemoryBarrierMask @barriers);
        void MemoryBarrierEXT(GlMemoryBarrierMask @barriers);
        void MemoryObjectParameterivEXT(uint @memoryObject, GlMemoryObjectParameterName @pname, int[] @params);
        void MinSampleShading(float @value);
        void MinSampleShadingARB(float @value);
        void MinSampleShadingOES(float @value);
        void Minmax(GlMinmaxTargetEXT @target, GlInternalFormat @internalformat, GlBoolean @sink);
        void MinmaxEXT(GlMinmaxTargetEXT @target, GlInternalFormat @internalformat, GlBoolean @sink);
        void MultMatrixd(double[] @m);
        void MultMatrixf(float[] @m);
        void MultMatrixx(int[] @m);
        void MultMatrixxOES(int[] @m);
        void MultTransposeMatrixd(double[] @m);
        void MultTransposeMatrixdARB(double[] @m);
        void MultTransposeMatrixf(float[] @m);
        void MultTransposeMatrixfARB(float[] @m);
        void MultTransposeMatrixxOES(int[] @m);
        void MultiDrawArrays(GlPrimitiveType @mode, int[] @first, int[] @count, int @drawcount);
        void MultiDrawArraysEXT(GlPrimitiveType @mode, int[] @first, int[] @count, int @primcount);
        void MultiDrawArraysIndirect(GlPrimitiveType @mode, byte[] @indirect, int @drawcount, int @stride);
        void MultiDrawArraysIndirectAMD(GlPrimitiveType @mode, byte[] @indirect, int @primcount, int @stride);
        void MultiDrawArraysIndirectBindlessCountNV(GlPrimitiveType @mode, byte[] @indirect, int @drawCount, int @maxDrawCount, int @stride, int @vertexBufferCount);
        void MultiDrawArraysIndirectBindlessNV(GlPrimitiveType @mode, byte[] @indirect, int @drawCount, int @stride, int @vertexBufferCount);
        void MultiDrawArraysIndirectCount(GlPrimitiveType @mode, byte[] @indirect, long @drawcount, int @maxdrawcount, int @stride);
        void MultiDrawArraysIndirectCountARB(GlPrimitiveType @mode, byte[] @indirect, long @drawcount, int @maxdrawcount, int @stride);
        void MultiDrawArraysIndirectEXT(GlPrimitiveType @mode, byte[] @indirect, int @drawcount, int @stride);
        void MultiDrawElementArrayAPPLE(GlPrimitiveType @mode, int[] @first, int[] @count, int @primcount);
        void MultiDrawElements(GlPrimitiveType @mode, int[] @count, GlDrawElementsType @type, byte[][] @indices, int @drawcount);
        void MultiDrawElementsBaseVertex(GlPrimitiveType @mode, int[] @count, GlDrawElementsType @type, byte[][] @indices, int @drawcount, int[] @basevertex);
        void MultiDrawElementsBaseVertexEXT(GlPrimitiveType @mode, int[] @count, GlDrawElementsType @type, byte[][] @indices, int @primcount, int[] @basevertex);
        void MultiDrawElementsEXT(GlPrimitiveType @mode, int[] @count, GlDrawElementsType @type, byte[][] @indices, int @primcount);
        void MultiDrawElementsIndirect(GlPrimitiveType @mode, GlDrawElementsType @type, byte[] @indirect, int @drawcount, int @stride);
        void MultiDrawElementsIndirectAMD(GlPrimitiveType @mode, GlDrawElementsType @type, byte[] @indirect, int @primcount, int @stride);
        void MultiDrawElementsIndirectBindlessCountNV(GlPrimitiveType @mode, GlDrawElementsType @type, byte[] @indirect, int @drawCount, int @maxDrawCount, int @stride, int @vertexBufferCount);
        void MultiDrawElementsIndirectBindlessNV(GlPrimitiveType @mode, GlDrawElementsType @type, byte[] @indirect, int @drawCount, int @stride, int @vertexBufferCount);
        void MultiDrawElementsIndirectCount(GlPrimitiveType @mode, uint @type, byte[] @indirect, long @drawcount, int @maxdrawcount, int @stride);
        void MultiDrawElementsIndirectCountARB(GlPrimitiveType @mode, GlDrawElementsType @type, byte[] @indirect, long @drawcount, int @maxdrawcount, int @stride);
        void MultiDrawElementsIndirectEXT(GlPrimitiveType @mode, GlDrawElementsType @type, byte[] @indirect, int @drawcount, int @stride);
        void MultiDrawRangeElementArrayAPPLE(GlPrimitiveType @mode, uint @start, uint @end, int[] @first, int[] @count, int @primcount);
        void MultiModeDrawArraysIBM(GlPrimitiveType[] @mode, int[] @first, int[] @count, int @primcount, int @modestride);
        void MultiModeDrawElementsIBM(GlPrimitiveType[] @mode, int[] @count, GlDrawElementsType @type, byte[][] @indices, int @primcount, int @modestride);
        void MultiTexBufferEXT(GlTextureUnit @texunit, GlTextureTarget @target, GlTypeEnum @internalformat, uint @buffer);
        void MultiTexCoord1bOES(GlTextureUnit @texture, sbyte @s);
        void MultiTexCoord1bvOES(GlTextureUnit @texture, sbyte[] @coords);
        void MultiTexCoord1d(GlTextureUnit @target, double @s);
        void MultiTexCoord1dARB(GlTextureUnit @target, double @s);
        void MultiTexCoord1dv(GlTextureUnit @target, double[] @v);
        void MultiTexCoord1dvARB(GlTextureUnit @target, double[] @v);
        void MultiTexCoord1f(GlTextureUnit @target, float @s);
        void MultiTexCoord1fARB(GlTextureUnit @target, float @s);
        void MultiTexCoord1fv(GlTextureUnit @target, float[] @v);
        void MultiTexCoord1fvARB(GlTextureUnit @target, float[] @v);
        void MultiTexCoord1hNV(GlTextureUnit @target, ushort @s);
        void MultiTexCoord1hvNV(GlTextureUnit @target, ushort[] @v);
        void MultiTexCoord1i(GlTextureUnit @target, int @s);
        void MultiTexCoord1iARB(GlTextureUnit @target, int @s);
        void MultiTexCoord1iv(GlTextureUnit @target, int[] @v);
        void MultiTexCoord1ivARB(GlTextureUnit @target, int[] @v);
        void MultiTexCoord1s(GlTextureUnit @target, short @s);
        void MultiTexCoord1sARB(GlTextureUnit @target, short @s);
        void MultiTexCoord1sv(GlTextureUnit @target, short[] @v);
        void MultiTexCoord1svARB(GlTextureUnit @target, short[] @v);
        void MultiTexCoord1xOES(GlTextureUnit @texture, int @s);
        void MultiTexCoord1xvOES(GlTextureUnit @texture, int[] @coords);
        void MultiTexCoord2bOES(GlTextureUnit @texture, sbyte @s, sbyte @t);
        void MultiTexCoord2bvOES(GlTextureUnit @texture, sbyte[] @coords);
        void MultiTexCoord2d(GlTextureUnit @target, double @s, double @t);
        void MultiTexCoord2dARB(GlTextureUnit @target, double @s, double @t);
        void MultiTexCoord2dv(GlTextureUnit @target, double[] @v);
        void MultiTexCoord2dvARB(GlTextureUnit @target, double[] @v);
        void MultiTexCoord2f(GlTextureUnit @target, float @s, float @t);
        void MultiTexCoord2fARB(GlTextureUnit @target, float @s, float @t);
        void MultiTexCoord2fv(GlTextureUnit @target, float[] @v);
        void MultiTexCoord2fvARB(GlTextureUnit @target, float[] @v);
        void MultiTexCoord2hNV(GlTextureUnit @target, ushort @s, ushort @t);
        void MultiTexCoord2hvNV(GlTextureUnit @target, ushort[] @v);
        void MultiTexCoord2i(GlTextureUnit @target, int @s, int @t);
        void MultiTexCoord2iARB(GlTextureUnit @target, int @s, int @t);
        void MultiTexCoord2iv(GlTextureUnit @target, int[] @v);
        void MultiTexCoord2ivARB(GlTextureUnit @target, int[] @v);
        void MultiTexCoord2s(GlTextureUnit @target, short @s, short @t);
        void MultiTexCoord2sARB(GlTextureUnit @target, short @s, short @t);
        void MultiTexCoord2sv(GlTextureUnit @target, short[] @v);
        void MultiTexCoord2svARB(GlTextureUnit @target, short[] @v);
        void MultiTexCoord2xOES(GlTextureUnit @texture, int @s, int @t);
        void MultiTexCoord2xvOES(GlTextureUnit @texture, int[] @coords);
        void MultiTexCoord3bOES(GlTextureUnit @texture, sbyte @s, sbyte @t, sbyte @r);
        void MultiTexCoord3bvOES(GlTextureUnit @texture, sbyte[] @coords);
        void MultiTexCoord3d(GlTextureUnit @target, double @s, double @t, double @r);
        void MultiTexCoord3dARB(GlTextureUnit @target, double @s, double @t, double @r);
        void MultiTexCoord3dv(GlTextureUnit @target, double[] @v);
        void MultiTexCoord3dvARB(GlTextureUnit @target, double[] @v);
        void MultiTexCoord3f(GlTextureUnit @target, float @s, float @t, float @r);
        void MultiTexCoord3fARB(GlTextureUnit @target, float @s, float @t, float @r);
        void MultiTexCoord3fv(GlTextureUnit @target, float[] @v);
        void MultiTexCoord3fvARB(GlTextureUnit @target, float[] @v);
        void MultiTexCoord3hNV(GlTextureUnit @target, ushort @s, ushort @t, ushort @r);
        void MultiTexCoord3hvNV(GlTextureUnit @target, ushort[] @v);
        void MultiTexCoord3i(GlTextureUnit @target, int @s, int @t, int @r);
        void MultiTexCoord3iARB(GlTextureUnit @target, int @s, int @t, int @r);
        void MultiTexCoord3iv(GlTextureUnit @target, int[] @v);
        void MultiTexCoord3ivARB(GlTextureUnit @target, int[] @v);
        void MultiTexCoord3s(GlTextureUnit @target, short @s, short @t, short @r);
        void MultiTexCoord3sARB(GlTextureUnit @target, short @s, short @t, short @r);
        void MultiTexCoord3sv(GlTextureUnit @target, short[] @v);
        void MultiTexCoord3svARB(GlTextureUnit @target, short[] @v);
        void MultiTexCoord3xOES(GlTextureUnit @texture, int @s, int @t, int @r);
        void MultiTexCoord3xvOES(GlTextureUnit @texture, int[] @coords);
        void MultiTexCoord4bOES(GlTextureUnit @texture, sbyte @s, sbyte @t, sbyte @r, sbyte @q);
        void MultiTexCoord4bvOES(GlTextureUnit @texture, sbyte[] @coords);
        void MultiTexCoord4d(GlTextureUnit @target, double @s, double @t, double @r, double @q);
        void MultiTexCoord4dARB(GlTextureUnit @target, double @s, double @t, double @r, double @q);
        void MultiTexCoord4dv(GlTextureUnit @target, double[] @v);
        void MultiTexCoord4dvARB(GlTextureUnit @target, double[] @v);
        void MultiTexCoord4f(GlTextureUnit @target, float @s, float @t, float @r, float @q);
        void MultiTexCoord4fARB(GlTextureUnit @target, float @s, float @t, float @r, float @q);
        void MultiTexCoord4fv(GlTextureUnit @target, float[] @v);
        void MultiTexCoord4fvARB(GlTextureUnit @target, float[] @v);
        void MultiTexCoord4hNV(GlTextureUnit @target, ushort @s, ushort @t, ushort @r, ushort @q);
        void MultiTexCoord4hvNV(GlTextureUnit @target, ushort[] @v);
        void MultiTexCoord4i(GlTextureUnit @target, int @s, int @t, int @r, int @q);
        void MultiTexCoord4iARB(GlTextureUnit @target, int @s, int @t, int @r, int @q);
        void MultiTexCoord4iv(GlTextureUnit @target, int[] @v);
        void MultiTexCoord4ivARB(GlTextureUnit @target, int[] @v);
        void MultiTexCoord4s(GlTextureUnit @target, short @s, short @t, short @r, short @q);
        void MultiTexCoord4sARB(GlTextureUnit @target, short @s, short @t, short @r, short @q);
        void MultiTexCoord4sv(GlTextureUnit @target, short[] @v);
        void MultiTexCoord4svARB(GlTextureUnit @target, short[] @v);
        void MultiTexCoord4x(GlTextureUnit @texture, int @s, int @t, int @r, int @q);
        void MultiTexCoord4xOES(GlTextureUnit @texture, int @s, int @t, int @r, int @q);
        void MultiTexCoord4xvOES(GlTextureUnit @texture, int[] @coords);
        void MultiTexCoordP1ui(GlTextureUnit @texture, GlTexCoordPointerType @type, uint @coords);
        void MultiTexCoordP1uiv(GlTextureUnit @texture, GlTexCoordPointerType @type, uint[] @coords);
        void MultiTexCoordP2ui(GlTextureUnit @texture, GlTexCoordPointerType @type, uint @coords);
        void MultiTexCoordP2uiv(GlTextureUnit @texture, GlTexCoordPointerType @type, uint[] @coords);
        void MultiTexCoordP3ui(GlTextureUnit @texture, GlTexCoordPointerType @type, uint @coords);
        void MultiTexCoordP3uiv(GlTextureUnit @texture, GlTexCoordPointerType @type, uint[] @coords);
        void MultiTexCoordP4ui(GlTextureUnit @texture, GlTexCoordPointerType @type, uint @coords);
        void MultiTexCoordP4uiv(GlTextureUnit @texture, GlTexCoordPointerType @type, uint[] @coords);
        void MultiTexCoordPointerEXT(GlTextureUnit @texunit, int @size, GlTexCoordPointerType @type, int @stride, byte[] @pointer);
        void MultiTexEnvfEXT(GlTextureUnit @texunit, GlTextureEnvTarget @target, GlTextureEnvParameter @pname, float @param);
        void MultiTexEnvfvEXT(GlTextureUnit @texunit, GlTextureEnvTarget @target, GlTextureEnvParameter @pname, float[] @params);
        void MultiTexEnviEXT(GlTextureUnit @texunit, GlTextureEnvTarget @target, GlTextureEnvParameter @pname, int @param);
        void MultiTexEnvivEXT(GlTextureUnit @texunit, GlTextureEnvTarget @target, GlTextureEnvParameter @pname, int[] @params);
        void MultiTexGendEXT(GlTextureUnit @texunit, GlTextureCoordName @coord, GlTextureGenParameter @pname, double @param);
        void MultiTexGendvEXT(GlTextureUnit @texunit, GlTextureCoordName @coord, GlTextureGenParameter @pname, double[] @params);
        void MultiTexGenfEXT(GlTextureUnit @texunit, GlTextureCoordName @coord, GlTextureGenParameter @pname, float @param);
        void MultiTexGenfvEXT(GlTextureUnit @texunit, GlTextureCoordName @coord, GlTextureGenParameter @pname, float[] @params);
        void MultiTexGeniEXT(GlTextureUnit @texunit, GlTextureCoordName @coord, GlTextureGenParameter @pname, int @param);
        void MultiTexGenivEXT(GlTextureUnit @texunit, GlTextureCoordName @coord, GlTextureGenParameter @pname, int[] @params);
        void MultiTexImage1DEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @border, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void MultiTexImage2DEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @border, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void MultiTexImage3DEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @depth, int @border, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void MultiTexParameterIivEXT(GlTextureUnit @texunit, GlTextureTarget @target, GlTextureParameterName @pname, int[] @params);
        void MultiTexParameterIuivEXT(GlTextureUnit @texunit, GlTextureTarget @target, GlTextureParameterName @pname, uint[] @params);
        void MultiTexParameterfEXT(GlTextureUnit @texunit, GlTextureTarget @target, GlTextureParameterName @pname, float @param);
        void MultiTexParameterfvEXT(GlTextureUnit @texunit, GlTextureTarget @target, GlTextureParameterName @pname, float[] @params);
        void MultiTexParameteriEXT(GlTextureUnit @texunit, GlTextureTarget @target, GlTextureParameterName @pname, int @param);
        void MultiTexParameterivEXT(GlTextureUnit @texunit, GlTextureTarget @target, GlTextureParameterName @pname, int[] @params);
        void MultiTexRenderbufferEXT(GlTextureUnit @texunit, GlTextureTarget @target, uint @renderbuffer);
        void MultiTexSubImage1DEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, int @xoffset, int @width, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void MultiTexSubImage2DEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @width, int @height, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void MultiTexSubImage3DEXT(GlTextureUnit @texunit, GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void MulticastBarrierNV();
        void MulticastBlitFramebufferNV(uint @srcGpu, uint @dstGpu, int @srcX0, int @srcY0, int @srcX1, int @srcY1, int @dstX0, int @dstY0, int @dstX1, int @dstY1, GlClearBufferMask @mask, uint @filter);
        void MulticastBufferSubDataNV(uint @gpuMask, uint @buffer, long @offset, long @size, byte[] @data);
        void MulticastCopyBufferSubDataNV(uint @readGpu, uint @writeGpuMask, uint @readBuffer, uint @writeBuffer, long @readOffset, long @writeOffset, long @size);
        void MulticastCopyImageSubDataNV(uint @srcGpu, uint @dstGpuMask, uint @srcName, uint @srcTarget, int @srcLevel, int @srcX, int @srcY, int @srcZ, uint @dstName, uint @dstTarget, int @dstLevel, int @dstX, int @dstY, int @dstZ, int @srcWidth, int @srcHeight, int @srcDepth);
        void MulticastFramebufferSampleLocationsfvNV(uint @gpu, uint @framebuffer, uint @start, int @count, float[] @v);
        void MulticastGetQueryObjecti64vNV(uint @gpu, uint @id, uint @pname, long[] @params);
        void MulticastGetQueryObjectivNV(uint @gpu, uint @id, uint @pname, int[] @params);
        void MulticastGetQueryObjectui64vNV(uint @gpu, uint @id, uint @pname, ulong[] @params);
        void MulticastGetQueryObjectuivNV(uint @gpu, uint @id, uint @pname, uint[] @params);
        void MulticastWaitSyncNV(uint @signalGpu, uint @waitGpuMask);
        void NamedBufferData(uint @buffer, long @size, byte[] @data, GlVertexBufferObjectUsage @usage);
        void NamedBufferDataEXT(uint @buffer, long @size, byte[] @data, GlVertexBufferObjectUsage @usage);
        void NamedBufferPageCommitmentARB(uint @buffer, long @offset, long @size, bool @commit);
        void NamedBufferPageCommitmentEXT(uint @buffer, long @offset, long @size, bool @commit);
        void NamedBufferStorage(uint @buffer, long @size, byte[] @data, GlMapBufferUsageMask @flags);
        void NamedBufferStorageExternalEXT(uint @buffer, long @offset, long @size, byte[] @clientBuffer, GlMapBufferUsageMask @flags);
        void NamedBufferStorageEXT(uint @buffer, long @size, byte[] @data, GlMapBufferUsageMask @flags);
        void NamedBufferStorageMemEXT(uint @buffer, long @size, uint @memory, ulong @offset);
        void NamedBufferSubData(uint @buffer, long @offset, long @size, byte[] @data);
        void NamedBufferSubDataEXT(uint @buffer, long @offset, long @size, byte[] @data);
        void NamedCopyBufferSubDataEXT(uint @readBuffer, uint @writeBuffer, long @readOffset, long @writeOffset, long @size);
        void NamedFramebufferDrawBuffer(uint @framebuffer, GlColorBuffer @buf);
        void NamedFramebufferDrawBuffers(uint @framebuffer, int @n, GlColorBuffer[] @bufs);
        void NamedFramebufferParameteri(uint @framebuffer, GlFramebufferParameterName @pname, int @param);
        void NamedFramebufferParameteriEXT(uint @framebuffer, GlFramebufferParameterName @pname, int @param);
        void NamedFramebufferReadBuffer(uint @framebuffer, GlColorBuffer @src);
        void NamedFramebufferRenderbuffer(uint @framebuffer, GlFramebufferAttachment @attachment, GlRenderbufferTarget @renderbuffertarget, uint @renderbuffer);
        void NamedFramebufferRenderbufferEXT(uint @framebuffer, GlFramebufferAttachment @attachment, GlRenderbufferTarget @renderbuffertarget, uint @renderbuffer);
        void NamedFramebufferSampleLocationsfvARB(uint @framebuffer, uint @start, int @count, float[] @v);
        void NamedFramebufferSampleLocationsfvNV(uint @framebuffer, uint @start, int @count, float[] @v);
        void NamedFramebufferTexture(uint @framebuffer, GlFramebufferAttachment @attachment, uint @texture, int @level);
        void NamedFramebufferSamplePositionsfvAMD(uint @framebuffer, uint @numsamples, uint @pixelindex, float[] @values);
        void NamedFramebufferTexture1DEXT(uint @framebuffer, GlFramebufferAttachment @attachment, GlTextureTarget @textarget, uint @texture, int @level);
        void NamedFramebufferTexture2DEXT(uint @framebuffer, GlFramebufferAttachment @attachment, GlTextureTarget @textarget, uint @texture, int @level);
        void NamedFramebufferTexture3DEXT(uint @framebuffer, GlFramebufferAttachment @attachment, GlTextureTarget @textarget, uint @texture, int @level, int @zoffset);
        void NamedFramebufferTextureEXT(uint @framebuffer, GlFramebufferAttachment @attachment, uint @texture, int @level);
        void NamedFramebufferTextureFaceEXT(uint @framebuffer, GlFramebufferAttachment @attachment, uint @texture, int @level, GlTextureTarget @face);
        void NamedFramebufferTextureLayer(uint @framebuffer, GlFramebufferAttachment @attachment, uint @texture, int @level, int @layer);
        void NamedFramebufferTextureLayerEXT(uint @framebuffer, GlFramebufferAttachment @attachment, uint @texture, int @level, int @layer);
        void NamedProgramLocalParameter4dEXT(uint @program, uint @target, uint @index, double @x, double @y, double @z, double @w);
        void NamedProgramLocalParameter4dvEXT(uint @program, uint @target, uint @index, double[] @params);
        void NamedProgramLocalParameter4fEXT(uint @program, uint @target, uint @index, float @x, float @y, float @z, float @w);
        void NamedProgramLocalParameter4fvEXT(uint @program, uint @target, uint @index, float[] @params);
        void NamedProgramLocalParameterI4iEXT(uint @program, uint @target, uint @index, int @x, int @y, int @z, int @w);
        void NamedProgramLocalParameterI4ivEXT(uint @program, uint @target, uint @index, int[] @params);
        void NamedProgramLocalParameterI4uiEXT(uint @program, uint @target, uint @index, uint @x, uint @y, uint @z, uint @w);
        void NamedProgramLocalParameterI4uivEXT(uint @program, uint @target, uint @index, uint[] @params);
        void NamedProgramLocalParameters4fvEXT(uint @program, uint @target, uint @index, int @count, float[] @params);
        void NamedProgramLocalParametersI4ivEXT(uint @program, uint @target, uint @index, int @count, int[] @params);
        void NamedProgramLocalParametersI4uivEXT(uint @program, uint @target, uint @index, int @count, uint[] @params);
        void NamedProgramStringEXT(uint @program, uint @target, uint @format, int @len, byte[] @string);
        void NamedRenderbufferStorage(uint @renderbuffer, GlInternalFormat @internalformat, int @width, int @height);
        void NamedRenderbufferStorageEXT(uint @renderbuffer, GlInternalFormat @internalformat, int @width, int @height);
        void NamedRenderbufferStorageMultisample(uint @renderbuffer, int @samples, GlInternalFormat @internalformat, int @width, int @height);
        void NamedRenderbufferStorageMultisampleCoverageEXT(uint @renderbuffer, int @coverageSamples, int @colorSamples, GlInternalFormat @internalformat, int @width, int @height);
        void NamedRenderbufferStorageMultisampleEXT(uint @renderbuffer, int @samples, GlInternalFormat @internalformat, int @width, int @height);
        void NamedStringARB(uint @type, int @namelen, byte[] @name, int @stringlen, byte[] @string);
        void NewList(uint @list, GlListMode @mode);
        uint NewObjectBufferATI(int @size, byte[] @pointer, uint @usage);
        void Normal3b(sbyte @nx, sbyte @ny, sbyte @nz);
        void Normal3bv(sbyte[] @v);
        void Normal3d(double @nx, double @ny, double @nz);
        void Normal3dv(double[] @v);
        void Normal3f(float @nx, float @ny, float @nz);
        void Normal3fVertex3fSUN(float @nx, float @ny, float @nz, float @x, float @y, float @z);
        void Normal3fVertex3fvSUN(float[] @n, float[] @v);
        void Normal3fv(float[] @v);
        void Normal3hNV(ushort @nx, ushort @ny, ushort @nz);
        void Normal3hvNV(ushort[] @v);
        void Normal3i(int @nx, int @ny, int @nz);
        void Normal3iv(int[] @v);
        void Normal3s(short @nx, short @ny, short @nz);
        void Normal3sv(short[] @v);
        void Normal3x(int @nx, int @ny, int @nz);
        void Normal3xOES(int @nx, int @ny, int @nz);
        void Normal3xvOES(int[] @coords);
        void NormalFormatNV(uint @type, int @stride);
        void NormalP3ui(GlNormalPointerType @type, uint @coords);
        void NormalP3uiv(GlNormalPointerType @type, uint[] @coords);
        void NormalPointer(GlNormalPointerType @type, int @stride, byte[] @pointer);
        void NormalPointerEXT(GlNormalPointerType @type, int @stride, int @count, byte[] @pointer);
        void NormalPointerListIBM(GlNormalPointerType @type, int @stride, byte[][] @pointer, int @ptrstride);
        void NormalPointervINTEL(GlNormalPointerType @type, byte[][] @pointer);
        void NormalStream3bATI(uint @stream, sbyte @nx, sbyte @ny, sbyte @nz);
        void NormalStream3bvATI(uint @stream, sbyte[] @coords);
        void NormalStream3dATI(uint @stream, double @nx, double @ny, double @nz);
        void NormalStream3dvATI(uint @stream, double[] @coords);
        void NormalStream3fATI(uint @stream, float @nx, float @ny, float @nz);
        void NormalStream3fvATI(uint @stream, float[] @coords);
        void NormalStream3iATI(uint @stream, int @nx, int @ny, int @nz);
        void NormalStream3ivATI(uint @stream, int[] @coords);
        void NormalStream3sATI(uint @stream, short @nx, short @ny, short @nz);
        void NormalStream3svATI(uint @stream, short[] @coords);
        void ObjectLabel(GlObjectIdentifier @identifier, uint @name, int @length, byte[] @label);
        void ObjectLabelKHR(GlObjectIdentifier @identifier, uint @name, int @length, byte[] @label);
        void ObjectPtrLabel(byte[] @ptr, int @length, byte[] @label);
        void ObjectPtrLabelKHR(byte[] @ptr, int @length, byte[] @label);
        uint ObjectPurgeableAPPLE(uint @objectType, uint @name, uint @option);
        uint ObjectUnpurgeableAPPLE(uint @objectType, uint @name, uint @option);
        void Ortho(double @left, double @right, double @bottom, double @top, double @zNear, double @zFar);
        void Orthof(float @l, float @r, float @b, float @t, float @n, float @f);
        void OrthofOES(float @l, float @r, float @b, float @t, float @n, float @f);
        void Orthox(int @l, int @r, int @b, int @t, int @n, int @f);
        void OrthoxOES(int @l, int @r, int @b, int @t, int @n, int @f);
        void PNTrianglesfATI(uint @pname, float @param);
        void PNTrianglesiATI(uint @pname, int @param);
        void PassTexCoordATI(uint @dst, uint @coord, uint @swizzle);
        void PassThrough(float @token);
        void PassThroughxOES(int @token);
        void PatchParameterfv(GlPatchParameterName @pname, float[] @values);
        void PatchParameteri(GlPatchParameterName @pname, int @value);
        void PatchParameteriEXT(GlPatchParameterName @pname, int @value);
        void PatchParameteriOES(GlPatchParameterName @pname, int @value);
        void PathColorGenNV(GlPathColor @color, GlPathGenMode @genMode, uint @colorFormat, float[] @coeffs);
        void PathCommandsNV(uint @path, int @numCommands, byte[] @commands, int @numCoords, uint @coordType, byte[] @coords);
        void PathCoordsNV(uint @path, int @numCoords, uint @coordType, byte[] @coords);
        void PathCoverDepthFuncNV(GlDepthFunction @func);
        void PathDashArrayNV(uint @path, int @dashCount, float[] @dashArray);
        void PathFogGenNV(GlPathGenMode @genMode);
        uint PathGlyphIndexArrayNV(uint @firstPathName, uint @fontTarget, byte[] @fontName, GlPathFontStyle @fontStyle, uint @firstGlyphIndex, int @numGlyphs, uint @pathParameterTemplate, float @emScale);
        uint PathGlyphIndexRangeNV(uint @fontTarget, byte[] @fontName, GlPathFontStyle @fontStyle, uint @pathParameterTemplate, float @emScale, uint @baseAndCount);
        void PathGlyphRangeNV(uint @firstPathName, GlPathFontTarget @fontTarget, byte[] @fontName, GlPathFontStyle @fontStyle, uint @firstGlyph, int @numGlyphs, GlPathHandleMissingGlyphs @handleMissingGlyphs, uint @pathParameterTemplate, float @emScale);
        void PathGlyphsNV(uint @firstPathName, GlPathFontTarget @fontTarget, byte[] @fontName, GlPathFontStyle @fontStyle, int @numGlyphs, GlPathElementType @type, byte[] @charcodes, GlPathHandleMissingGlyphs @handleMissingGlyphs, uint @pathParameterTemplate, float @emScale);
        uint PathMemoryGlyphIndexArrayNV(uint @firstPathName, uint @fontTarget, long @fontSize, byte[] @fontData, int @faceIndex, uint @firstGlyphIndex, int @numGlyphs, uint @pathParameterTemplate, float @emScale);
        void PathParameterfNV(uint @path, GlPathParameter @pname, float @value);
        void PathParameterfvNV(uint @path, GlPathParameter @pname, float[] @value);
        void PathParameteriNV(uint @path, GlPathParameter @pname, int @value);
        void PathParameterivNV(uint @path, GlPathParameter @pname, int[] @value);
        void PathStencilDepthOffsetNV(float @factor, float @units);
        void PathStencilFuncNV(GlStencilFunction @func, int @ref, uint @mask);
        void PathStringNV(uint @path, GlPathStringFormat @format, int @length, byte[] @pathString);
        void PathSubCommandsNV(uint @path, int @commandStart, int @commandsToDelete, int @numCommands, byte[] @commands, int @numCoords, uint @coordType, byte[] @coords);
        void PathSubCoordsNV(uint @path, int @coordStart, int @numCoords, uint @coordType, byte[] @coords);
        void PathTexGenNV(GlPathColor @texCoordSet, GlPathGenMode @genMode, int @components, float[] @coeffs);
        void PauseTransformFeedback();
        void PauseTransformFeedbackNV();
        void PixelDataRangeNV(uint @target, int @length, byte[] @pointer);
        void PixelMapfv(GlPixelMap @map, int @mapsize, float[] @values);
        void PixelMapuiv(GlPixelMap @map, int @mapsize, uint[] @values);
        void PixelMapusv(GlPixelMap @map, int @mapsize, ushort[] @values);
        void PixelMapx(GlPixelMap @map, int @size, int[] @values);
        void PixelStoref(GlPixelStoreParameter @pname, float @param);
        void PixelStorei(GlPixelStoreParameter @pname, int @param);
        void PixelStorex(GlPixelStoreParameter @pname, int @param);
        void PixelTexGenParameterfSGIS(GlPixelTexGenParameterNameSGIS @pname, float @param);
        void PixelTexGenParameterfvSGIS(GlPixelTexGenParameterNameSGIS @pname, float[] @params);
        void PixelTexGenParameteriSGIS(GlPixelTexGenParameterNameSGIS @pname, int @param);
        void PixelTexGenParameterivSGIS(GlPixelTexGenParameterNameSGIS @pname, int[] @params);
        void PixelTexGenSGIX(uint @mode);
        void PixelTransferf(GlPixelTransferParameter @pname, float @param);
        void PixelTransferi(GlPixelTransferParameter @pname, int @param);
        void PixelTransferxOES(GlPixelTransferParameter @pname, int @param);
        void PixelTransformParameterfEXT(uint @target, uint @pname, float @param);
        void PixelTransformParameterfvEXT(uint @target, uint @pname, float[] @params);
        void PixelTransformParameteriEXT(uint @target, uint @pname, int @param);
        void PixelTransformParameterivEXT(uint @target, uint @pname, int[] @params);
        void PixelZoom(float @xfactor, float @yfactor);
        void PixelZoomxOES(int @xfactor, int @yfactor);
        bool PointAlongPathNV(uint @path, int @startSegment, int @numSegments, float @distance, float[] @x, float[] @y, float[] @tangentX, float[] @tangentY);
        void PointParameterf(uint @pname, float @param);
        void PointParameterfARB(uint @pname, float @param);
        void PointParameterfEXT(uint @pname, float @param);
        void PointParameterfSGIS(uint @pname, float @param);
        void PointParameterfv(uint @pname, float[] @params);
        void PointParameterfvARB(uint @pname, float[] @params);
        void PointParameterfvEXT(uint @pname, float[] @params);
        void PointParameterfvSGIS(uint @pname, float[] @params);
        void PointParameteri(uint @pname, int @param);
        void PointParameteriNV(uint @pname, int @param);
        void PointParameteriv(uint @pname, int[] @params);
        void PointParameterivNV(uint @pname, int[] @params);
        void PointParameterx(uint @pname, int @param);
        void PointParameterxOES(uint @pname, int @param);
        void PointParameterxv(uint @pname, int[] @params);
        void PointParameterxvOES(uint @pname, int[] @params);
        void PointSize(float @size);
        void PointSizePointerOES(uint @type, int @stride, byte[] @pointer);
        void PointSizex(int @size);
        void PointSizexOES(int @size);
        int PollAsyncSGIX(uint[] @markerp);
        int PollInstrumentsSGIX(int[] @marker_p);
        void PolygonMode(GlMaterialFace @face, GlPolygonMode @mode);
        void PolygonModeNV(GlMaterialFace @face, GlPolygonMode @mode);
        void PolygonOffset(float @factor, float @units);
        void PolygonOffsetClamp(float @factor, float @units, float @clamp);
        void PolygonOffsetClampEXT(float @factor, float @units, float @clamp);
        void PolygonOffsetEXT(float @factor, float @bias);
        void PolygonOffsetx(int @factor, int @units);
        void PolygonOffsetxOES(int @factor, int @units);
        void PolygonStipple(byte[] @mask);
        void PopAttrib();
        void PopClientAttrib();
        void PopDebugGroup();
        void PopDebugGroupKHR();
        void PopGroupMarkerEXT();
        void PopMatrix();
        void PopName();
        void PresentFrameDualFillNV(uint @video_slot, ulong @minPresentTime, uint @beginPresentTimeId, uint @presentDurationId, uint @type, uint @target0, uint @fill0, uint @target1, uint @fill1, uint @target2, uint @fill2, uint @target3, uint @fill3);
        void PresentFrameKeyedNV(uint @video_slot, ulong @minPresentTime, uint @beginPresentTimeId, uint @presentDurationId, uint @type, uint @target0, uint @fill0, uint @key0, uint @target1, uint @fill1, uint @key1);
        void PrimitiveBoundingBox(float @minX, float @minY, float @minZ, float @minW, float @maxX, float @maxY, float @maxZ, float @maxW);
        void PrimitiveBoundingBoxARB(float @minX, float @minY, float @minZ, float @minW, float @maxX, float @maxY, float @maxZ, float @maxW);
        void PrimitiveBoundingBoxEXT(float @minX, float @minY, float @minZ, float @minW, float @maxX, float @maxY, float @maxZ, float @maxW);
        void PrimitiveBoundingBoxOES(float @minX, float @minY, float @minZ, float @minW, float @maxX, float @maxY, float @maxZ, float @maxW);
        void PrimitiveRestartIndex(uint @index);
        void PrimitiveRestartIndexNV(uint @index);
        void PrimitiveRestartNV();
        void PrioritizeTextures(int @n, uint[] @textures, float[] @priorities);
        void PrioritizeTexturesEXT(int @n, uint[] @textures, float[] @priorities);
        void PrioritizeTexturesxOES(int @n, uint[] @textures, int[] @priorities);
        void ProgramBinary(uint @program, uint @binaryFormat, byte[] @binary, int @length);
        void ProgramBinaryOES(uint @program, uint @binaryFormat, byte[] @binary, int @length);
        void ProgramBufferParametersIivNV(uint @target, uint @bindingIndex, uint @wordIndex, int @count, int[] @params);
        void ProgramBufferParametersIuivNV(uint @target, uint @bindingIndex, uint @wordIndex, int @count, uint[] @params);
        void ProgramBufferParametersfvNV(uint @target, uint @bindingIndex, uint @wordIndex, int @count, float[] @params);
        void ProgramEnvParameter4dARB(uint @target, uint @index, double @x, double @y, double @z, double @w);
        void ProgramEnvParameter4dvARB(uint @target, uint @index, double[] @params);
        void ProgramEnvParameter4fARB(uint @target, uint @index, float @x, float @y, float @z, float @w);
        void ProgramEnvParameter4fvARB(uint @target, uint @index, float[] @params);
        void ProgramEnvParameterI4iNV(uint @target, uint @index, int @x, int @y, int @z, int @w);
        void ProgramEnvParameterI4ivNV(uint @target, uint @index, int[] @params);
        void ProgramEnvParameterI4uiNV(uint @target, uint @index, uint @x, uint @y, uint @z, uint @w);
        void ProgramEnvParameterI4uivNV(uint @target, uint @index, uint[] @params);
        void ProgramEnvParameters4fvEXT(uint @target, uint @index, int @count, float[] @params);
        void ProgramEnvParametersI4ivNV(uint @target, uint @index, int @count, int[] @params);
        void ProgramEnvParametersI4uivNV(uint @target, uint @index, int @count, uint[] @params);
        void ProgramLocalParameter4dARB(uint @target, uint @index, double @x, double @y, double @z, double @w);
        void ProgramLocalParameter4dvARB(uint @target, uint @index, double[] @params);
        void ProgramLocalParameter4fARB(uint @target, uint @index, float @x, float @y, float @z, float @w);
        void ProgramLocalParameter4fvARB(uint @target, uint @index, float[] @params);
        void ProgramLocalParameterI4iNV(uint @target, uint @index, int @x, int @y, int @z, int @w);
        void ProgramLocalParameterI4ivNV(uint @target, uint @index, int[] @params);
        void ProgramLocalParameterI4uiNV(uint @target, uint @index, uint @x, uint @y, uint @z, uint @w);
        void ProgramLocalParameterI4uivNV(uint @target, uint @index, uint[] @params);
        void ProgramLocalParameters4fvEXT(uint @target, uint @index, int @count, float[] @params);
        void ProgramLocalParametersI4ivNV(uint @target, uint @index, int @count, int[] @params);
        void ProgramLocalParametersI4uivNV(uint @target, uint @index, int @count, uint[] @params);
        void ProgramNamedParameter4dNV(uint @id, int @len, byte[] @name, double @x, double @y, double @z, double @w);
        void ProgramNamedParameter4dvNV(uint @id, int @len, byte[] @name, double[] @v);
        void ProgramNamedParameter4fNV(uint @id, int @len, byte[] @name, float @x, float @y, float @z, float @w);
        void ProgramNamedParameter4fvNV(uint @id, int @len, byte[] @name, float[] @v);
        void ProgramParameter4dNV(uint @target, uint @index, double @x, double @y, double @z, double @w);
        void ProgramParameter4dvNV(uint @target, uint @index, double[] @v);
        void ProgramParameter4fNV(uint @target, uint @index, float @x, float @y, float @z, float @w);
        void ProgramParameter4fvNV(uint @target, uint @index, float[] @v);
        void ProgramParameteri(uint @program, GlProgramParameterPName @pname, int @value);
        void ProgramParameteriARB(uint @program, GlProgramParameterPName @pname, int @value);
        void ProgramParameteriEXT(uint @program, GlProgramParameterPName @pname, int @value);
        void ProgramParameters4dvNV(uint @target, uint @index, int @count, double[] @v);
        void ProgramParameters4fvNV(uint @target, uint @index, int @count, float[] @v);
        void ProgramPathFragmentInputGenNV(uint @program, int @location, uint @genMode, int @components, float[] @coeffs);
        void ProgramStringARB(uint @target, uint @format, int @len, byte[] @string);
        void ProgramSubroutineParametersuivNV(uint @target, int @count, uint[] @params);
        void ProgramUniform1d(uint @program, int @location, double @v0);
        void ProgramUniform1dEXT(uint @program, int @location, double @x);
        void ProgramUniform1dv(uint @program, int @location, int @count, double[] @value);
        void ProgramUniform1dvEXT(uint @program, int @location, int @count, double[] @value);
        void ProgramUniform1f(uint @program, int @location, float @v0);
        void ProgramUniform1fEXT(uint @program, int @location, float @v0);
        void ProgramUniform1fv(uint @program, int @location, int @count, float[] @value);
        void ProgramUniform1fvEXT(uint @program, int @location, int @count, float[] @value);
        void ProgramUniform1i(uint @program, int @location, int @v0);
        void ProgramUniform1i64ARB(uint @program, int @location, long @x);
        void ProgramUniform1i64NV(uint @program, int @location, long @x);
        void ProgramUniform1i64vARB(uint @program, int @location, int @count, long[] @value);
        void ProgramUniform1i64vNV(uint @program, int @location, int @count, long[] @value);
        void ProgramUniform1iEXT(uint @program, int @location, int @v0);
        void ProgramUniform1iv(uint @program, int @location, int @count, int[] @value);
        void ProgramUniform1ivEXT(uint @program, int @location, int @count, int[] @value);
        void ProgramUniform1ui(uint @program, int @location, uint @v0);
        void ProgramUniform1ui64ARB(uint @program, int @location, ulong @x);
        void ProgramUniform1ui64NV(uint @program, int @location, ulong @x);
        void ProgramUniform1ui64vARB(uint @program, int @location, int @count, ulong[] @value);
        void ProgramUniform1ui64vNV(uint @program, int @location, int @count, ulong[] @value);
        void ProgramUniform1uiEXT(uint @program, int @location, uint @v0);
        void ProgramUniform1uiv(uint @program, int @location, int @count, uint[] @value);
        void ProgramUniform1uivEXT(uint @program, int @location, int @count, uint[] @value);
        void ProgramUniform2d(uint @program, int @location, double @v0, double @v1);
        void ProgramUniform2dEXT(uint @program, int @location, double @x, double @y);
        void ProgramUniform2dv(uint @program, int @location, int @count, double[] @value);
        void ProgramUniform2dvEXT(uint @program, int @location, int @count, double[] @value);
        void ProgramUniform2f(uint @program, int @location, float @v0, float @v1);
        void ProgramUniform2fEXT(uint @program, int @location, float @v0, float @v1);
        void ProgramUniform2fv(uint @program, int @location, int @count, float[] @value);
        void ProgramUniform2fvEXT(uint @program, int @location, int @count, float[] @value);
        void ProgramUniform2i(uint @program, int @location, int @v0, int @v1);
        void ProgramUniform2i64ARB(uint @program, int @location, long @x, long @y);
        void ProgramUniform2i64NV(uint @program, int @location, long @x, long @y);
        void ProgramUniform2i64vARB(uint @program, int @location, int @count, long[] @value);
        void ProgramUniform2i64vNV(uint @program, int @location, int @count, long[] @value);
        void ProgramUniform2iEXT(uint @program, int @location, int @v0, int @v1);
        void ProgramUniform2iv(uint @program, int @location, int @count, int[] @value);
        void ProgramUniform2ivEXT(uint @program, int @location, int @count, int[] @value);
        void ProgramUniform2ui(uint @program, int @location, uint @v0, uint @v1);
        void ProgramUniform2ui64ARB(uint @program, int @location, ulong @x, ulong @y);
        void ProgramUniform2ui64NV(uint @program, int @location, ulong @x, ulong @y);
        void ProgramUniform2ui64vARB(uint @program, int @location, int @count, ulong[] @value);
        void ProgramUniform2ui64vNV(uint @program, int @location, int @count, ulong[] @value);
        void ProgramUniform2uiEXT(uint @program, int @location, uint @v0, uint @v1);
        void ProgramUniform2uiv(uint @program, int @location, int @count, uint[] @value);
        void ProgramUniform2uivEXT(uint @program, int @location, int @count, uint[] @value);
        void ProgramUniform3d(uint @program, int @location, double @v0, double @v1, double @v2);
        void ProgramUniform3dEXT(uint @program, int @location, double @x, double @y, double @z);
        void ProgramUniform3dv(uint @program, int @location, int @count, double[] @value);
        void ProgramUniform3dvEXT(uint @program, int @location, int @count, double[] @value);
        void ProgramUniform3f(uint @program, int @location, float @v0, float @v1, float @v2);
        void ProgramUniform3fEXT(uint @program, int @location, float @v0, float @v1, float @v2);
        void ProgramUniform3fv(uint @program, int @location, int @count, float[] @value);
        void ProgramUniform3fvEXT(uint @program, int @location, int @count, float[] @value);
        void ProgramUniform3i(uint @program, int @location, int @v0, int @v1, int @v2);
        void ProgramUniform3i64ARB(uint @program, int @location, long @x, long @y, long @z);
        void ProgramUniform3i64NV(uint @program, int @location, long @x, long @y, long @z);
        void ProgramUniform3i64vARB(uint @program, int @location, int @count, long[] @value);
        void ProgramUniform3i64vNV(uint @program, int @location, int @count, long[] @value);
        void ProgramUniform3iEXT(uint @program, int @location, int @v0, int @v1, int @v2);
        void ProgramUniform3iv(uint @program, int @location, int @count, int[] @value);
        void ProgramUniform3ivEXT(uint @program, int @location, int @count, int[] @value);
        void ProgramUniform3ui(uint @program, int @location, uint @v0, uint @v1, uint @v2);
        void ProgramUniform3ui64ARB(uint @program, int @location, ulong @x, ulong @y, ulong @z);
        void ProgramUniform3ui64NV(uint @program, int @location, ulong @x, ulong @y, ulong @z);
        void ProgramUniform3ui64vARB(uint @program, int @location, int @count, ulong[] @value);
        void ProgramUniform3ui64vNV(uint @program, int @location, int @count, ulong[] @value);
        void ProgramUniform3uiEXT(uint @program, int @location, uint @v0, uint @v1, uint @v2);
        void ProgramUniform3uiv(uint @program, int @location, int @count, uint[] @value);
        void ProgramUniform3uivEXT(uint @program, int @location, int @count, uint[] @value);
        void ProgramUniform4d(uint @program, int @location, double @v0, double @v1, double @v2, double @v3);
        void ProgramUniform4dEXT(uint @program, int @location, double @x, double @y, double @z, double @w);
        void ProgramUniform4dv(uint @program, int @location, int @count, double[] @value);
        void ProgramUniform4dvEXT(uint @program, int @location, int @count, double[] @value);
        void ProgramUniform4f(uint @program, int @location, float @v0, float @v1, float @v2, float @v3);
        void ProgramUniform4fEXT(uint @program, int @location, float @v0, float @v1, float @v2, float @v3);
        void ProgramUniform4fv(uint @program, int @location, int @count, float[] @value);
        void ProgramUniform4fvEXT(uint @program, int @location, int @count, float[] @value);
        void ProgramUniform4i(uint @program, int @location, int @v0, int @v1, int @v2, int @v3);
        void ProgramUniform4i64ARB(uint @program, int @location, long @x, long @y, long @z, long @w);
        void ProgramUniform4i64NV(uint @program, int @location, long @x, long @y, long @z, long @w);
        void ProgramUniform4i64vARB(uint @program, int @location, int @count, long[] @value);
        void ProgramUniform4i64vNV(uint @program, int @location, int @count, long[] @value);
        void ProgramUniform4iEXT(uint @program, int @location, int @v0, int @v1, int @v2, int @v3);
        void ProgramUniform4iv(uint @program, int @location, int @count, int[] @value);
        void ProgramUniform4ivEXT(uint @program, int @location, int @count, int[] @value);
        void ProgramUniform4ui(uint @program, int @location, uint @v0, uint @v1, uint @v2, uint @v3);
        void ProgramUniform4ui64ARB(uint @program, int @location, ulong @x, ulong @y, ulong @z, ulong @w);
        void ProgramUniform4ui64NV(uint @program, int @location, ulong @x, ulong @y, ulong @z, ulong @w);
        void ProgramUniform4ui64vARB(uint @program, int @location, int @count, ulong[] @value);
        void ProgramUniform4ui64vNV(uint @program, int @location, int @count, ulong[] @value);
        void ProgramUniform4uiEXT(uint @program, int @location, uint @v0, uint @v1, uint @v2, uint @v3);
        void ProgramUniform4uiv(uint @program, int @location, int @count, uint[] @value);
        void ProgramUniform4uivEXT(uint @program, int @location, int @count, uint[] @value);
        void ProgramUniformHandleui64ARB(uint @program, int @location, ulong @value);
        void ProgramUniformHandleui64IMG(uint @program, int @location, ulong @value);
        void ProgramUniformHandleui64NV(uint @program, int @location, ulong @value);
        void ProgramUniformHandleui64vARB(uint @program, int @location, int @count, ulong[] @values);
        void ProgramUniformHandleui64vIMG(uint @program, int @location, int @count, ulong[] @values);
        void ProgramUniformHandleui64vNV(uint @program, int @location, int @count, ulong[] @values);
        void ProgramUniformMatrix2dv(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix2dvEXT(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix2fv(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformMatrix2fvEXT(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformMatrix2x3dv(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix2x3dvEXT(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix2x3fv(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformMatrix2x3fvEXT(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformMatrix2x4dv(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix2x4dvEXT(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix2x4fv(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformMatrix2x4fvEXT(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformMatrix3dv(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix3dvEXT(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix3fv(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformMatrix3fvEXT(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformMatrix3x2dv(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix3x2dvEXT(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix3x2fv(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformMatrix3x2fvEXT(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformMatrix3x4dv(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix3x4dvEXT(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix3x4fv(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformMatrix3x4fvEXT(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformMatrix4dv(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix4dvEXT(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix4fv(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformMatrix4fvEXT(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformMatrix4x2dv(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix4x2dvEXT(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix4x2fv(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformMatrix4x2fvEXT(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformMatrix4x3dv(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix4x3dvEXT(uint @program, int @location, int @count, GlBoolean @transpose, double[] @value);
        void ProgramUniformMatrix4x3fv(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformMatrix4x3fvEXT(uint @program, int @location, int @count, GlBoolean @transpose, float[] @value);
        void ProgramUniformui64NV(uint @program, int @location, ulong @value);
        void ProgramUniformui64vNV(uint @program, int @location, int @count, ulong[] @value);
        void ProgramVertexLimitNV(uint @target, int @limit);
        void ProvokingVertex(GlVertexProvokingMode @mode);
        void ProvokingVertexEXT(GlVertexProvokingMode @mode);
        void PushAttrib(GlAttribMask @mask);
        void PushClientAttrib(GlClientAttribMask @mask);
        void PushClientAttribDefaultEXT(GlClientAttribMask @mask);
        void PushDebugGroup(GlDebugSource @source, uint @id, int @length, byte[] @message);
        void PushDebugGroupKHR(GlDebugSource @source, uint @id, int @length, byte[] @message);
        void PushGroupMarkerEXT(int @length, byte[] @marker);
        void PushMatrix();
        void PushName(uint @name);
        void QueryCounter(uint @id, GlQueryTarget @target);
        void QueryCounterEXT(uint @id, GlQueryTarget @target);
        uint QueryMatrixxOES(int[] @mantissa, int[] @exponent);
        void QueryObjectParameteruiAMD(GlQueryTarget @target, uint @id, uint @pname, GlOcclusionQueryEventMaskAMD @param);
        int QueryResourceNV(uint @queryType, int @tagId, uint @bufSize, int[] @buffer);
        void QueryResourceTagNV(int @tagId, byte[] @tagString);
        void RasterPos2d(double @x, double @y);
        void RasterPos2dv(double[] @v);
        void RasterPos2f(float @x, float @y);
        void RasterPos2fv(float[] @v);
        void RasterPos2i(int @x, int @y);
        void RasterPos2iv(int[] @v);
        void RasterPos2s(short @x, short @y);
        void RasterPos2sv(short[] @v);
        void RasterPos2xOES(int @x, int @y);
        void RasterPos2xvOES(int[] @coords);
        void RasterPos3d(double @x, double @y, double @z);
        void RasterPos3dv(double[] @v);
        void RasterPos3f(float @x, float @y, float @z);
        void RasterPos3fv(float[] @v);
        void RasterPos3i(int @x, int @y, int @z);
        void RasterPos3iv(int[] @v);
        void RasterPos3s(short @x, short @y, short @z);
        void RasterPos3sv(short[] @v);
        void RasterPos3xOES(int @x, int @y, int @z);
        void RasterPos3xvOES(int[] @coords);
        void RasterPos4d(double @x, double @y, double @z, double @w);
        void RasterPos4dv(double[] @v);
        void RasterPos4f(float @x, float @y, float @z, float @w);
        void RasterPos4fv(float[] @v);
        void RasterPos4i(int @x, int @y, int @z, int @w);
        void RasterPos4iv(int[] @v);
        void RasterPos4s(short @x, short @y, short @z, short @w);
        void RasterPos4sv(short[] @v);
        void RasterPos4xOES(int @x, int @y, int @z, int @w);
        void RasterPos4xvOES(int[] @coords);
        void RasterSamplesEXT(uint @samples, bool @fixedsamplelocations);
        void ReadBuffer(GlReadBufferMode @src);
        void ReadBufferIndexedEXT(GlReadBufferMode @src, int @index);
        void ReadBufferNV(uint @mode);
        void ReadInstrumentsSGIX(int @marker);
        void ReadPixels(int @x, int @y, int @width, int @height, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void ReadnPixels(int @x, int @y, int @width, int @height, GlPixelFormat @format, GlPixelType @type, int @bufSize, byte[] @data);
        void ReadnPixelsARB(int @x, int @y, int @width, int @height, GlPixelFormat @format, GlPixelType @type, int @bufSize, byte[] @data);
        void ReadnPixelsEXT(int @x, int @y, int @width, int @height, GlPixelFormat @format, GlPixelType @type, int @bufSize, byte[] @data);
        void ReadnPixelsKHR(int @x, int @y, int @width, int @height, GlPixelFormat @format, GlPixelType @type, int @bufSize, byte[] @data);
        bool ReleaseKeyedMutexWin32EXT(uint @memory, ulong @key);
        void Rectd(double @x1, double @y1, double @x2, double @y2);
        void Rectdv(double[] @v1, double[] @v2);
        void Rectf(float @x1, float @y1, float @x2, float @y2);
        void Rectfv(float[] @v1, float[] @v2);
        void Recti(int @x1, int @y1, int @x2, int @y2);
        void Rectiv(int[] @v1, int[] @v2);
        void Rects(short @x1, short @y1, short @x2, short @y2);
        void Rectsv(short[] @v1, short[] @v2);
        void RectxOES(int @x1, int @y1, int @x2, int @y2);
        void RectxvOES(int[] @v1, int[] @v2);
        void ReferencePlaneSGIX(double[] @equation);
        void ReleaseShaderCompiler();
        void RenderGpuMaskNV(uint @mask);
        int RenderMode(GlRenderingMode @mode);
        void RenderbufferStorage(GlRenderbufferTarget @target, GlInternalFormat @internalformat, int @width, int @height);
        void RenderbufferStorageEXT(GlRenderbufferTarget @target, GlInternalFormat @internalformat, int @width, int @height);
        void RenderbufferStorageMultisample(GlRenderbufferTarget @target, int @samples, GlInternalFormat @internalformat, int @width, int @height);
        void RenderbufferStorageMultisampleANGLE(GlRenderbufferTarget @target, int @samples, GlInternalFormat @internalformat, int @width, int @height);
        void RenderbufferStorageMultisampleAPPLE(GlRenderbufferTarget @target, int @samples, GlInternalFormat @internalformat, int @width, int @height);
        void RenderbufferStorageMultisampleCoverageNV(GlRenderbufferTarget @target, int @coverageSamples, int @colorSamples, GlInternalFormat @internalformat, int @width, int @height);
        void RenderbufferStorageMultisampleEXT(GlRenderbufferTarget @target, int @samples, GlInternalFormat @internalformat, int @width, int @height);
        void RenderbufferStorageMultisampleIMG(GlRenderbufferTarget @target, int @samples, GlInternalFormat @internalformat, int @width, int @height);
        void RenderbufferStorageMultisampleNV(GlRenderbufferTarget @target, int @samples, GlInternalFormat @internalformat, int @width, int @height);
        void RenderbufferStorageOES(GlRenderbufferTarget @target, GlInternalFormat @internalformat, int @width, int @height);
        void ReplacementCodePointerSUN(uint @type, int @stride, byte[][] @pointer);
        void ReplacementCodeubSUN(byte @code);
        void ReplacementCodeubvSUN(byte[] @code);
        void ReplacementCodeuiColor3fVertex3fSUN(uint @rc, float @r, float @g, float @b, float @x, float @y, float @z);
        void ReplacementCodeuiColor3fVertex3fvSUN(uint[] @rc, float[] @c, float[] @v);
        void ReplacementCodeuiColor4fNormal3fVertex3fSUN(uint @rc, float @r, float @g, float @b, float @a, float @nx, float @ny, float @nz, float @x, float @y, float @z);
        void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(uint[] @rc, float[] @c, float[] @n, float[] @v);
        void ReplacementCodeuiColor4ubVertex3fSUN(uint @rc, byte @r, byte @g, byte @b, byte @a, float @x, float @y, float @z);
        void ReplacementCodeuiColor4ubVertex3fvSUN(uint[] @rc, byte[] @c, float[] @v);
        void ReplacementCodeuiNormal3fVertex3fSUN(uint @rc, float @nx, float @ny, float @nz, float @x, float @y, float @z);
        void ReplacementCodeuiNormal3fVertex3fvSUN(uint[] @rc, float[] @n, float[] @v);
        void ReplacementCodeuiSUN(uint @code);
        void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(uint @rc, float @s, float @t, float @r, float @g, float @b, float @a, float @nx, float @ny, float @nz, float @x, float @y, float @z);
        void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(uint[] @rc, float[] @tc, float[] @c, float[] @n, float[] @v);
        void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(uint @rc, float @s, float @t, float @nx, float @ny, float @nz, float @x, float @y, float @z);
        void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(uint[] @rc, float[] @tc, float[] @n, float[] @v);
        void ReplacementCodeuiTexCoord2fVertex3fSUN(uint @rc, float @s, float @t, float @x, float @y, float @z);
        void ReplacementCodeuiTexCoord2fVertex3fvSUN(uint[] @rc, float[] @tc, float[] @v);
        void ReplacementCodeuiVertex3fSUN(uint @rc, float @x, float @y, float @z);
        void ReplacementCodeuiVertex3fvSUN(uint[] @rc, float[] @v);
        void ReplacementCodeuivSUN(uint[] @code);
        void ReplacementCodeusSUN(ushort @code);
        void ReplacementCodeusvSUN(ushort[] @code);
        void RequestResidentProgramsNV(int @n, uint[] @programs);
        void ResetHistogram(GlHistogramTargetEXT @target);
        void ResetHistogramEXT(GlHistogramTargetEXT @target);
        void ResetMinmax(GlMinmaxTargetEXT @target);
        void ResetMinmaxEXT(GlMinmaxTargetEXT @target);
        void ResizeBuffersMESA();
        void ResolveDepthValuesNV();
        void ResolveMultisampleFramebufferAPPLE();
        void ResumeTransformFeedback();
        void ResumeTransformFeedbackNV();
        void Rotated(double @angle, double @x, double @y, double @z);
        void Rotatef(float @angle, float @x, float @y, float @z);
        void Rotatex(int @angle, int @x, int @y, int @z);
        void RotatexOES(int @angle, int @x, int @y, int @z);
        void SampleCoverage(float @value, GlBoolean @invert);
        void SampleCoverageARB(float @value, GlBoolean @invert);
        void SampleCoveragex(int @value, bool @invert);
        void SampleCoveragexOES(int @value, bool @invert);
        void SampleMapATI(uint @dst, uint @interp, uint @swizzle);
        void SampleMaskEXT(float @value, GlBoolean @invert);
        void SampleMaskIndexedNV(uint @index, uint @mask);
        void SampleMaskSGIS(float @value, GlBoolean @invert);
        void SampleMaski(uint @maskNumber, uint @mask);
        void SamplePatternEXT(uint @pattern);
        void SamplePatternSGIS(GlSamplePatternSGIS @pattern);
        void SamplerParameterIiv(uint @sampler, GlSamplerParameterName @pname, int[] @param);
        void SamplerParameterIivEXT(uint @sampler, GlSamplerParameterName @pname, int[] @param);
        void SamplerParameterIivOES(uint @sampler, GlSamplerParameterName @pname, int[] @param);
        void SamplerParameterIuiv(uint @sampler, GlSamplerParameterName @pname, uint[] @param);
        void SamplerParameterIuivEXT(uint @sampler, GlSamplerParameterName @pname, uint[] @param);
        void SamplerParameterIuivOES(uint @sampler, GlSamplerParameterName @pname, uint[] @param);
        void SamplerParameterf(uint @sampler, GlSamplerParameterName @pname, float @param);
        void SamplerParameterfv(uint @sampler, GlSamplerParameterName @pname, float[] @param);
        void SamplerParameteri(uint @sampler, GlSamplerParameterName @pname, int @param);
        void SamplerParameteriv(uint @sampler, GlSamplerParameterName @pname, int[] @param);
        void Scaled(double @x, double @y, double @z);
        void Scalef(float @x, float @y, float @z);
        void Scalex(int @x, int @y, int @z);
        void ScalexOES(int @x, int @y, int @z);
        void Scissor(int @x, int @y, int @width, int @height);
        void ScissorArrayv(uint @first, int @count, int[] @v);
        void ScissorArrayvNV(uint @first, int @count, int[] @v);
        void ScissorArrayvOES(uint @first, int @count, int[] @v);
        void ScissorIndexed(uint @index, int @left, int @bottom, int @width, int @height);
        void ScissorIndexedNV(uint @index, int @left, int @bottom, int @width, int @height);
        void ScissorIndexedOES(uint @index, int @left, int @bottom, int @width, int @height);
        void ScissorIndexedv(uint @index, int[] @v);
        void ScissorIndexedvNV(uint @index, int[] @v);
        void ScissorIndexedvOES(uint @index, int[] @v);
        void SecondaryColor3b(sbyte @red, sbyte @green, sbyte @blue);
        void SecondaryColor3bEXT(sbyte @red, sbyte @green, sbyte @blue);
        void SecondaryColor3bv(sbyte[] @v);
        void SecondaryColor3bvEXT(sbyte[] @v);
        void SecondaryColor3d(double @red, double @green, double @blue);
        void SecondaryColor3dEXT(double @red, double @green, double @blue);
        void SecondaryColor3dv(double[] @v);
        void SecondaryColor3dvEXT(double[] @v);
        void SecondaryColor3f(float @red, float @green, float @blue);
        void SecondaryColor3fEXT(float @red, float @green, float @blue);
        void SecondaryColor3fv(float[] @v);
        void SecondaryColor3fvEXT(float[] @v);
        void SecondaryColor3hNV(ushort @red, ushort @green, ushort @blue);
        void SecondaryColor3hvNV(ushort[] @v);
        void SecondaryColor3i(int @red, int @green, int @blue);
        void SecondaryColor3iEXT(int @red, int @green, int @blue);
        void SecondaryColor3iv(int[] @v);
        void SecondaryColor3ivEXT(int[] @v);
        void SecondaryColor3s(short @red, short @green, short @blue);
        void SecondaryColor3sEXT(short @red, short @green, short @blue);
        void SecondaryColor3sv(short[] @v);
        void SecondaryColor3svEXT(short[] @v);
        void SecondaryColor3ub(byte @red, byte @green, byte @blue);
        void SecondaryColor3ubEXT(byte @red, byte @green, byte @blue);
        void SecondaryColor3ubv(byte[] @v);
        void SecondaryColor3ubvEXT(byte[] @v);
        void SecondaryColor3ui(uint @red, uint @green, uint @blue);
        void SecondaryColor3uiEXT(uint @red, uint @green, uint @blue);
        void SecondaryColor3uiv(uint[] @v);
        void SecondaryColor3uivEXT(uint[] @v);
        void SecondaryColor3us(ushort @red, ushort @green, ushort @blue);
        void SecondaryColor3usEXT(ushort @red, ushort @green, ushort @blue);
        void SecondaryColor3usv(ushort[] @v);
        void SecondaryColor3usvEXT(ushort[] @v);
        void SecondaryColorFormatNV(int @size, GlColorPointerType @type, int @stride);
        void SecondaryColorP3ui(GlColorPointerType @type, uint @color);
        void SecondaryColorP3uiv(GlColorPointerType @type, uint[] @color);
        void SecondaryColorPointer(int @size, GlColorPointerType @type, int @stride, byte[] @pointer);
        void SecondaryColorPointerEXT(int @size, GlColorPointerType @type, int @stride, byte[] @pointer);
        void SecondaryColorPointerListIBM(int @size, uint @type, int @stride, byte[][] @pointer, int @ptrstride);
        void SelectBuffer(int @size, uint[] @buffer);
        void SelectPerfMonitorCountersAMD(uint @monitor, GlBoolean @enable, uint @group, int @numCounters, uint[] @counterList);
        void SemaphoreParameterui64vEXT(uint @semaphore, GlSemaphoreParameterName @pname, ulong[] @params);
        void SeparableFilter2D(GlSeparableTargetEXT @target, GlInternalFormat @internalformat, int @width, int @height, GlPixelFormat @format, GlPixelType @type, byte[] @row, byte[] @column);
        void SeparableFilter2DEXT(GlSeparableTargetEXT @target, GlInternalFormat @internalformat, int @width, int @height, GlPixelFormat @format, GlPixelType @type, byte[] @row, byte[] @column);
        void SetFenceAPPLE(uint @fence);
        void SetFenceNV(uint @fence, uint @condition);
        void SetFragmentShaderConstantATI(uint @dst, float[] @value);
        void SetInvariantEXT(uint @id, uint @type, byte[] @addr);
        void SetLocalConstantEXT(uint @id, uint @type, byte[] @addr);
        void SetMultisamplefvAMD(uint @pname, uint @index, float[] @val);
        void ShadeModel(GlShadingModel @mode);
        void ShaderBinary(int @count, uint[] @shaders, uint @binaryformat, byte[] @binary, int @length);
        void ShaderOp1EXT(uint @op, uint @res, uint @arg1);
        void ShaderOp2EXT(uint @op, uint @res, uint @arg1, uint @arg2);
        void ShaderOp3EXT(uint @op, uint @res, uint @arg1, uint @arg2, uint @arg3);
        void ShaderSource(uint @shader, int @count, byte[][] @string, int[] @length);
        void ShaderSourceARB(IntPtr @shaderObj, int @count, byte[][] @string, int[] @length);
        void ShaderStorageBlockBinding(uint @program, uint @storageBlockIndex, uint @storageBlockBinding);
        void SharpenTexFuncSGIS(GlTextureTarget @target, int @n, float[] @points);
        void SignalSemaphoreEXT(uint @semaphore, uint @numBufferBarriers, uint[] @buffers, uint @numTextureBarriers, uint[] @textures, GlTextureLayout[] @dstLayouts);
        void SpecializeShader(uint @shader, byte[] @pEntryPoint, uint @numSpecializationConstants, uint[] @pConstantIndex, uint[] @pConstantValue);
        void SpecializeShaderARB(uint @shader, byte[] @pEntryPoint, uint @numSpecializationConstants, uint[] @pConstantIndex, uint[] @pConstantValue);
        void SpriteParameterfSGIX(uint @pname, float @param);
        void SpriteParameterfvSGIX(uint @pname, float[] @params);
        void SpriteParameteriSGIX(uint @pname, int @param);
        void SpriteParameterivSGIX(uint @pname, int[] @params);
        void StartInstrumentsSGIX();
        void StartTilingQCOM(uint @x, uint @y, uint @width, uint @height, GlBufferBitQCOM @preserveMask);
        void StateCaptureNV(uint @state, uint @mode);
        void StencilClearTagEXT(int @stencilTagBits, uint @stencilClearTag);
        void StencilFillPathInstancedNV(int @numPaths, GlPathElementType @pathNameType, byte[] @paths, uint @pathBase, GlPathFillMode @fillMode, uint @mask, GlPathTransformType @transformType, float[] @transformValues);
        void StencilFillPathNV(uint @path, GlPathFillMode @fillMode, uint @mask);
        void StencilFunc(GlStencilFunction @func, int @ref, uint @mask);
        void StencilFuncSeparate(GlStencilFaceDirection @face, GlStencilFunction @func, int @ref, uint @mask);
        void StencilFuncSeparateATI(GlStencilFunction @frontfunc, GlStencilFunction @backfunc, int @ref, uint @mask);
        void StencilMask(uint @mask);
        void StencilMaskSeparate(GlStencilFaceDirection @face, uint @mask);
        void StencilOp(GlStencilOp @fail, GlStencilOp @zfail, GlStencilOp @zpass);
        void StencilOpSeparate(GlStencilFaceDirection @face, GlStencilOp @sfail, GlStencilOp @dpfail, GlStencilOp @dppass);
        void StencilOpSeparateATI(GlStencilFaceDirection @face, GlStencilOp @sfail, GlStencilOp @dpfail, GlStencilOp @dppass);
        void StencilOpValueAMD(GlStencilFaceDirection @face, uint @value);
        void StencilStrokePathInstancedNV(int @numPaths, GlPathElementType @pathNameType, byte[] @paths, uint @pathBase, int @reference, uint @mask, GlPathTransformType @transformType, float[] @transformValues);
        void StencilStrokePathNV(uint @path, int @reference, uint @mask);
        void StencilThenCoverFillPathInstancedNV(int @numPaths, uint @pathNameType, byte[] @paths, uint @pathBase, uint @fillMode, uint @mask, uint @coverMode, uint @transformType, float[] @transformValues);
        void StencilThenCoverFillPathNV(uint @path, uint @fillMode, uint @mask, uint @coverMode);
        void StencilThenCoverStrokePathInstancedNV(int @numPaths, uint @pathNameType, byte[] @paths, uint @pathBase, int @reference, uint @mask, uint @coverMode, uint @transformType, float[] @transformValues);
        void StencilThenCoverStrokePathNV(uint @path, int @reference, uint @mask, uint @coverMode);
        void StopInstrumentsSGIX(int @marker);
        void StringMarkerGREMEDY(int @len, byte[] @string);
        void SubpixelPrecisionBiasNV(uint @xbits, uint @ybits);
        void SwizzleEXT(uint @res, uint @in, uint @outX, uint @outY, uint @outZ, uint @outW);
        void SyncTextureINTEL(uint @texture);
        void TagSampleBufferSGIX();
        void Tangent3bEXT(sbyte @tx, sbyte @ty, sbyte @tz);
        void Tangent3bvEXT(sbyte[] @v);
        void Tangent3dEXT(double @tx, double @ty, double @tz);
        void Tangent3dvEXT(double[] @v);
        void Tangent3fEXT(float @tx, float @ty, float @tz);
        void Tangent3fvEXT(float[] @v);
        void Tangent3iEXT(int @tx, int @ty, int @tz);
        void Tangent3ivEXT(int[] @v);
        void Tangent3sEXT(short @tx, short @ty, short @tz);
        void Tangent3svEXT(short[] @v);
        void TangentPointerEXT(uint @type, int @stride, byte[] @pointer);
        void TbufferMask3DFX(uint @mask);
        void TessellationFactorAMD(float @factor);
        void TessellationModeAMD(uint @mode);
        bool TestFenceAPPLE(uint @fence);
        bool TestFenceNV(uint @fence);
        bool TestObjectAPPLE(uint @object, uint @name);
        void TexBuffer(GlTextureTarget @target, GlInternalFormat @internalformat, uint @buffer);
        void TexBufferARB(GlTextureTarget @target, GlInternalFormat @internalformat, uint @buffer);
        void TexBufferEXT(GlTextureTarget @target, GlInternalFormat @internalformat, uint @buffer);
        void TexBufferOES(GlTextureTarget @target, GlInternalFormat @internalformat, uint @buffer);
        void TexBufferRange(GlTextureTarget @target, GlInternalFormat @internalformat, uint @buffer, long @offset, long @size);
        void TexBufferRangeEXT(GlTextureTarget @target, GlInternalFormat @internalformat, uint @buffer, long @offset, long @size);
        void TexBufferRangeOES(GlTextureTarget @target, GlInternalFormat @internalformat, uint @buffer, long @offset, long @size);
        void TexBumpParameterfvATI(uint @pname, float[] @param);
        void TexBumpParameterivATI(uint @pname, int[] @param);
        void TexCoord1bOES(sbyte @s);
        void TexCoord1bvOES(sbyte[] @coords);
        void TexCoord1d(double @s);
        void TexCoord1dv(double[] @v);
        void TexCoord1f(float @s);
        void TexCoord1fv(float[] @v);
        void TexCoord1hNV(ushort @s);
        void TexCoord1hvNV(ushort[] @v);
        void TexCoord1i(int @s);
        void TexCoord1iv(int[] @v);
        void TexCoord1s(short @s);
        void TexCoord1sv(short[] @v);
        void TexCoord1xOES(int @s);
        void TexCoord1xvOES(int[] @coords);
        void TexCoord2bOES(sbyte @s, sbyte @t);
        void TexCoord2bvOES(sbyte[] @coords);
        void TexCoord2d(double @s, double @t);
        void TexCoord2dv(double[] @v);
        void TexCoord2f(float @s, float @t);
        void TexCoord2fColor3fVertex3fSUN(float @s, float @t, float @r, float @g, float @b, float @x, float @y, float @z);
        void TexCoord2fColor3fVertex3fvSUN(float[] @tc, float[] @c, float[] @v);
        void TexCoord2fColor4fNormal3fVertex3fSUN(float @s, float @t, float @r, float @g, float @b, float @a, float @nx, float @ny, float @nz, float @x, float @y, float @z);
        void TexCoord2fColor4fNormal3fVertex3fvSUN(float[] @tc, float[] @c, float[] @n, float[] @v);
        void TexCoord2fColor4ubVertex3fSUN(float @s, float @t, byte @r, byte @g, byte @b, byte @a, float @x, float @y, float @z);
        void TexCoord2fColor4ubVertex3fvSUN(float[] @tc, byte[] @c, float[] @v);
        void TexCoord2fNormal3fVertex3fSUN(float @s, float @t, float @nx, float @ny, float @nz, float @x, float @y, float @z);
        void TexCoord2fNormal3fVertex3fvSUN(float[] @tc, float[] @n, float[] @v);
        void TexCoord2fVertex3fSUN(float @s, float @t, float @x, float @y, float @z);
        void TexCoord2fVertex3fvSUN(float[] @tc, float[] @v);
        void TexCoord2fv(float[] @v);
        void TexCoord2hNV(ushort @s, ushort @t);
        void TexCoord2hvNV(ushort[] @v);
        void TexCoord2i(int @s, int @t);
        void TexCoord2iv(int[] @v);
        void TexCoord2s(short @s, short @t);
        void TexCoord2sv(short[] @v);
        void TexCoord2xOES(int @s, int @t);
        void TexCoord2xvOES(int[] @coords);
        void TexCoord3bOES(sbyte @s, sbyte @t, sbyte @r);
        void TexCoord3bvOES(sbyte[] @coords);
        void TexCoord3d(double @s, double @t, double @r);
        void TexCoord3dv(double[] @v);
        void TexCoord3f(float @s, float @t, float @r);
        void TexCoord3fv(float[] @v);
        void TexCoord3hNV(ushort @s, ushort @t, ushort @r);
        void TexCoord3hvNV(ushort[] @v);
        void TexCoord3i(int @s, int @t, int @r);
        void TexCoord3iv(int[] @v);
        void TexCoord3s(short @s, short @t, short @r);
        void TexCoord3sv(short[] @v);
        void TexCoord3xOES(int @s, int @t, int @r);
        void TexCoord3xvOES(int[] @coords);
        void TexCoord4bOES(sbyte @s, sbyte @t, sbyte @r, sbyte @q);
        void TexCoord4bvOES(sbyte[] @coords);
        void TexCoord4d(double @s, double @t, double @r, double @q);
        void TexCoord4dv(double[] @v);
        void TexCoord4f(float @s, float @t, float @r, float @q);
        void TexCoord4fColor4fNormal3fVertex4fSUN(float @s, float @t, float @p, float @q, float @r, float @g, float @b, float @a, float @nx, float @ny, float @nz, float @x, float @y, float @z, float @w);
        void TexCoord4fColor4fNormal3fVertex4fvSUN(float[] @tc, float[] @c, float[] @n, float[] @v);
        void TexCoord4fVertex4fSUN(float @s, float @t, float @p, float @q, float @x, float @y, float @z, float @w);
        void TexCoord4fVertex4fvSUN(float[] @tc, float[] @v);
        void TexCoord4fv(float[] @v);
        void TexCoord4hNV(ushort @s, ushort @t, ushort @r, ushort @q);
        void TexCoord4hvNV(ushort[] @v);
        void TexCoord4i(int @s, int @t, int @r, int @q);
        void TexCoord4iv(int[] @v);
        void TexCoord4s(short @s, short @t, short @r, short @q);
        void TexCoord4sv(short[] @v);
        void TexCoord4xOES(int @s, int @t, int @r, int @q);
        void TexCoord4xvOES(int[] @coords);
        void TexCoordFormatNV(int @size, uint @type, int @stride);
        void TexCoordP1ui(GlTexCoordPointerType @type, uint @coords);
        void TexCoordP1uiv(GlTexCoordPointerType @type, uint[] @coords);
        void TexCoordP2ui(GlTexCoordPointerType @type, uint @coords);
        void TexCoordP2uiv(GlTexCoordPointerType @type, uint[] @coords);
        void TexCoordP3ui(GlTexCoordPointerType @type, uint @coords);
        void TexCoordP3uiv(GlTexCoordPointerType @type, uint[] @coords);
        void TexCoordP4ui(GlTexCoordPointerType @type, uint @coords);
        void TexCoordP4uiv(GlTexCoordPointerType @type, uint[] @coords);
        void TexCoordPointer(int @size, GlTexCoordPointerType @type, int @stride, byte[] @pointer);
        void TexCoordPointerEXT(int @size, GlTexCoordPointerType @type, int @stride, int @count, byte[] @pointer);
        void TexCoordPointerListIBM(int @size, GlTexCoordPointerType @type, int @stride, byte[][] @pointer, int @ptrstride);
        void TexCoordPointervINTEL(int @size, GlVertexPointerType @type, byte[][] @pointer);
        void TexEnvf(GlTextureEnvTarget @target, GlTextureEnvParameter @pname, float @param);
        void TexEnvfv(GlTextureEnvTarget @target, GlTextureEnvParameter @pname, float[] @params);
        void TexEnvi(GlTextureEnvTarget @target, GlTextureEnvParameter @pname, int @param);
        void TexEnviv(GlTextureEnvTarget @target, GlTextureEnvParameter @pname, int[] @params);
        void TexEnvx(GlTextureEnvTarget @target, GlTextureEnvParameter @pname, int @param);
        void TexEnvxOES(GlTextureEnvTarget @target, GlTextureEnvParameter @pname, int @param);
        void TexEnvxv(GlTextureEnvTarget @target, GlTextureEnvParameter @pname, int[] @params);
        void TexEnvxvOES(GlTextureEnvTarget @target, GlTextureEnvParameter @pname, int[] @params);
        void TexFilterFuncSGIS(GlTextureTarget @target, uint @filter, int @n, float[] @weights);
        void TexGend(GlTextureCoordName @coord, GlTextureGenParameter @pname, double @param);
        void TexGendv(GlTextureCoordName @coord, GlTextureGenParameter @pname, double[] @params);
        void TexGenf(GlTextureCoordName @coord, GlTextureGenParameter @pname, float @param);
        void TexGenfOES(GlTextureCoordName @coord, GlTextureGenParameter @pname, float @param);
        void TexGenfv(GlTextureCoordName @coord, GlTextureGenParameter @pname, float[] @params);
        void TexGenfvOES(GlTextureCoordName @coord, GlTextureGenParameter @pname, float[] @params);
        void TexGeni(GlTextureCoordName @coord, GlTextureGenParameter @pname, int @param);
        void TexGeniOES(GlTextureCoordName @coord, GlTextureGenParameter @pname, int @param);
        void TexGeniv(GlTextureCoordName @coord, GlTextureGenParameter @pname, int[] @params);
        void TexGenivOES(GlTextureCoordName @coord, GlTextureGenParameter @pname, int[] @params);
        void TexGenxOES(GlTextureCoordName @coord, GlTextureGenParameter @pname, int @param);
        void TexGenxvOES(GlTextureCoordName @coord, GlTextureGenParameter @pname, int[] @params);
        void TexImage1D(GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @border, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TexImage2D(GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @border, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TexImage2DMultisample(GlTextureTarget @target, int @samples, GlInternalFormat @internalformat, int @width, int @height, GlBoolean @fixedsamplelocations);
        void TexImage2DMultisampleCoverageNV(GlTextureTarget @target, int @coverageSamples, int @colorSamples, int @internalFormat, int @width, int @height, GlBoolean @fixedSampleLocations);
        void TexImage3D(GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @depth, int @border, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TexImage3DEXT(GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @depth, int @border, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TexImage3DMultisample(GlTextureTarget @target, int @samples, GlInternalFormat @internalformat, int @width, int @height, int @depth, GlBoolean @fixedsamplelocations);
        void TexImage3DMultisampleCoverageNV(GlTextureTarget @target, int @coverageSamples, int @colorSamples, int @internalFormat, int @width, int @height, int @depth, GlBoolean @fixedSampleLocations);
        void TexImage3DOES(GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @depth, int @border, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TexImage4DSGIS(GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @depth, int @size4d, int @border, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TexPageCommitmentARB(uint @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, bool @commit);
        void TexPageCommitmentEXT(uint @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, bool @commit);
        void TexParameterIiv(GlTextureTarget @target, GlTextureParameterName @pname, int[] @params);
        void TexParameterIivEXT(GlTextureTarget @target, GlTextureParameterName @pname, int[] @params);
        void TexParameterIivOES(GlTextureTarget @target, GlTextureParameterName @pname, int[] @params);
        void TexParameterIuiv(GlTextureTarget @target, GlTextureParameterName @pname, uint[] @params);
        void TexParameterIuivEXT(GlTextureTarget @target, GlTextureParameterName @pname, uint[] @params);
        void TexParameterIuivOES(GlTextureTarget @target, GlTextureParameterName @pname, uint[] @params);
        void TexParameterf(GlTextureTarget @target, GlTextureParameterName @pname, float @param);
        void TexParameterfv(GlTextureTarget @target, GlTextureParameterName @pname, float[] @params);
        void TexParameteri(GlTextureTarget @target, GlTextureParameterName @pname, int @param);
        void TexParameteriv(GlTextureTarget @target, GlTextureParameterName @pname, int[] @params);
        void TexParameterx(GlTextureTarget @target, GlGetTextureParameter @pname, int @param);
        void TexParameterxOES(GlTextureTarget @target, GlGetTextureParameter @pname, int @param);
        void TexParameterxv(GlTextureTarget @target, GlGetTextureParameter @pname, int[] @params);
        void TexParameterxvOES(GlTextureTarget @target, GlGetTextureParameter @pname, int[] @params);
        void TexRenderbufferNV(GlTextureTarget @target, uint @renderbuffer);
        void TexStorage1D(GlTextureTarget @target, int @levels, GlInternalFormat @internalformat, int @width);
        void TexStorage1DEXT(GlTextureTarget @target, int @levels, GlInternalFormat @internalformat, int @width);
        void TexStorage2D(GlTextureTarget @target, int @levels, GlInternalFormat @internalformat, int @width, int @height);
        void TexStorage2DEXT(GlTextureTarget @target, int @levels, GlInternalFormat @internalformat, int @width, int @height);
        void TexStorage2DMultisample(GlTextureTarget @target, int @samples, GlInternalFormat @internalformat, int @width, int @height, GlBoolean @fixedsamplelocations);
        void TexStorage3D(GlTextureTarget @target, int @levels, GlInternalFormat @internalformat, int @width, int @height, int @depth);
        void TexStorage3DEXT(GlTextureTarget @target, int @levels, GlInternalFormat @internalformat, int @width, int @height, int @depth);
        void TexStorage3DMultisample(GlTextureTarget @target, int @samples, GlInternalFormat @internalformat, int @width, int @height, int @depth, GlBoolean @fixedsamplelocations);
        void TexStorage3DMultisampleOES(GlTextureTarget @target, int @samples, GlInternalFormat @internalformat, int @width, int @height, int @depth, GlBoolean @fixedsamplelocations);
        void TexStorageMem1DEXT(GlTextureTarget @target, int @levels, uint @internalFormat, int @width, uint @memory, ulong @offset);
        void TexStorageMem2DEXT(GlTextureTarget @target, int @levels, uint @internalFormat, int @width, int @height, uint @memory, ulong @offset);
        void TexStorageMem2DMultisampleEXT(GlTextureTarget @target, int @samples, uint @internalFormat, int @width, int @height, bool @fixedSampleLocations, uint @memory, ulong @offset);
        void TexStorageMem3DEXT(GlTextureTarget @target, int @levels, uint @internalFormat, int @width, int @height, int @depth, uint @memory, ulong @offset);
        void TexStorageMem3DMultisampleEXT(GlTextureTarget @target, int @samples, uint @internalFormat, int @width, int @height, int @depth, bool @fixedSampleLocations, uint @memory, ulong @offset);
        void TexStorageSparseAMD(GlTextureTarget @target, GlInternalFormat @internalFormat, int @width, int @height, int @depth, int @layers, GlTextureStorageMaskAMD @flags);
        void TexSubImage1D(GlTextureTarget @target, int @level, int @xoffset, int @width, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TexSubImage1DEXT(GlTextureTarget @target, int @level, int @xoffset, int @width, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TexSubImage2D(GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @width, int @height, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TexSubImage2DEXT(GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @width, int @height, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TexSubImage3D(GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TexSubImage3DEXT(GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TexSubImage3DOES(GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TexSubImage4DSGIS(GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @woffset, int @width, int @height, int @depth, int @size4d, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TextureBarrier();
        void TextureBarrierNV();
        void TextureBuffer(uint @texture, GlInternalFormat @internalformat, uint @buffer);
        void TextureBufferEXT(uint @texture, GlTextureTarget @target, GlInternalFormat @internalformat, uint @buffer);
        void TextureBufferRange(uint @texture, GlInternalFormat @internalformat, uint @buffer, long @offset, long @size);
        void TextureBufferRangeEXT(uint @texture, GlTextureTarget @target, GlInternalFormat @internalformat, uint @buffer, long @offset, long @size);
        void TextureColorMaskSGIS(GlBoolean @red, GlBoolean @green, GlBoolean @blue, GlBoolean @alpha);
        void TextureFoveationParametersQCOM(uint @texture, uint @layer, uint @focalPoint, float @focalX, float @focalY, float @gainX, float @gainY, float @foveaArea);
        void TextureImage1DEXT(uint @texture, GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @border, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TextureImage2DEXT(uint @texture, GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @border, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TextureImage2DMultisampleCoverageNV(uint @texture, GlTextureTarget @target, int @coverageSamples, int @colorSamples, int @internalFormat, int @width, int @height, GlBoolean @fixedSampleLocations);
        void TextureImage2DMultisampleNV(uint @texture, GlTextureTarget @target, int @samples, int @internalFormat, int @width, int @height, GlBoolean @fixedSampleLocations);
        void TextureImage3DEXT(uint @texture, GlTextureTarget @target, int @level, GlInternalFormat @internalformat, int @width, int @height, int @depth, int @border, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TextureImage3DMultisampleCoverageNV(uint @texture, GlTextureTarget @target, int @coverageSamples, int @colorSamples, int @internalFormat, int @width, int @height, int @depth, GlBoolean @fixedSampleLocations);
        void TextureImage3DMultisampleNV(uint @texture, GlTextureTarget @target, int @samples, int @internalFormat, int @width, int @height, int @depth, GlBoolean @fixedSampleLocations);
        void TextureLightEXT(uint @pname);
        void TextureMaterialEXT(GlMaterialFace @face, GlMaterialParameter @mode);
        void TextureNormalEXT(uint @mode);
        void TexturePageCommitmentEXT(uint @texture, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, bool @commit);
        void TextureParameterIiv(uint @texture, GlTextureParameterName @pname, int[] @params);
        void TextureParameterIivEXT(uint @texture, GlTextureTarget @target, GlTextureParameterName @pname, int[] @params);
        void TextureParameterIuiv(uint @texture, GlTextureParameterName @pname, uint[] @params);
        void TextureParameterIuivEXT(uint @texture, GlTextureTarget @target, GlTextureParameterName @pname, uint[] @params);
        void TextureParameterf(uint @texture, GlTextureParameterName @pname, float @param);
        void TextureParameterfEXT(uint @texture, GlTextureTarget @target, GlTextureParameterName @pname, float @param);
        void TextureParameterfv(uint @texture, GlTextureParameterName @pname, float[] @param);
        void TextureParameterfvEXT(uint @texture, GlTextureTarget @target, GlTextureParameterName @pname, float[] @params);
        void TextureParameteri(uint @texture, GlTextureParameterName @pname, int @param);
        void TextureParameteriEXT(uint @texture, GlTextureTarget @target, GlTextureParameterName @pname, int @param);
        void TextureParameteriv(uint @texture, GlTextureParameterName @pname, int[] @param);
        void TextureParameterivEXT(uint @texture, GlTextureTarget @target, GlTextureParameterName @pname, int[] @params);
        void TextureRangeAPPLE(uint @target, int @length, byte[] @pointer);
        void TextureRenderbufferEXT(uint @texture, GlTextureTarget @target, uint @renderbuffer);
        void TextureStorage1D(uint @texture, int @levels, GlInternalFormat @internalformat, int @width);
        void TextureStorage1DEXT(uint @texture, uint @target, int @levels, GlInternalFormat @internalformat, int @width);
        void TextureStorage2D(uint @texture, int @levels, GlInternalFormat @internalformat, int @width, int @height);
        void TextureStorage2DEXT(uint @texture, uint @target, int @levels, GlInternalFormat @internalformat, int @width, int @height);
        void TextureStorage2DMultisample(uint @texture, int @samples, GlInternalFormat @internalformat, int @width, int @height, bool @fixedsamplelocations);
        void TextureStorage2DMultisampleEXT(uint @texture, GlTextureTarget @target, int @samples, GlInternalFormat @internalformat, int @width, int @height, GlBoolean @fixedsamplelocations);
        void TextureStorage3D(uint @texture, int @levels, GlInternalFormat @internalformat, int @width, int @height, int @depth);
        void TextureStorage3DEXT(uint @texture, uint @target, int @levels, GlInternalFormat @internalformat, int @width, int @height, int @depth);
        void TextureStorage3DMultisample(uint @texture, int @samples, GlInternalFormat @internalformat, int @width, int @height, int @depth, bool @fixedsamplelocations);
        void TextureStorage3DMultisampleEXT(uint @texture, uint @target, int @samples, GlInternalFormat @internalformat, int @width, int @height, int @depth, GlBoolean @fixedsamplelocations);
        void TextureStorageMem1DEXT(uint @texture, int @levels, uint @internalFormat, int @width, uint @memory, ulong @offset);
        void TextureStorageMem2DEXT(uint @texture, int @levels, uint @internalFormat, int @width, int @height, uint @memory, ulong @offset);
        void TextureStorageMem2DMultisampleEXT(uint @texture, int @samples, uint @internalFormat, int @width, int @height, bool @fixedSampleLocations, uint @memory, ulong @offset);
        void TextureStorageMem3DEXT(uint @texture, int @levels, uint @internalFormat, int @width, int @height, int @depth, uint @memory, ulong @offset);
        void TextureStorageMem3DMultisampleEXT(uint @texture, int @samples, uint @internalFormat, int @width, int @height, int @depth, bool @fixedSampleLocations, uint @memory, ulong @offset);
        void TextureStorageSparseAMD(uint @texture, uint @target, GlInternalFormat @internalFormat, int @width, int @height, int @depth, int @layers, GlTextureStorageMaskAMD @flags);
        void TextureSubImage1D(uint @texture, int @level, int @xoffset, int @width, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TextureSubImage1DEXT(uint @texture, GlTextureTarget @target, int @level, int @xoffset, int @width, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TextureSubImage2D(uint @texture, int @level, int @xoffset, int @yoffset, int @width, int @height, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TextureSubImage2DEXT(uint @texture, GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @width, int @height, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TextureSubImage3D(uint @texture, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TextureSubImage3DEXT(uint @texture, GlTextureTarget @target, int @level, int @xoffset, int @yoffset, int @zoffset, int @width, int @height, int @depth, GlPixelFormat @format, GlPixelType @type, byte[] @pixels);
        void TextureView(uint @texture, GlTextureTarget @target, uint @origtexture, GlInternalFormat @internalformat, uint @minlevel, uint @numlevels, uint @minlayer, uint @numlayers);
        void TextureViewEXT(uint @texture, GlTextureTarget @target, uint @origtexture, GlInternalFormat @internalformat, uint @minlevel, uint @numlevels, uint @minlayer, uint @numlayers);
        void TextureViewOES(uint @texture, GlTextureTarget @target, uint @origtexture, GlInternalFormat @internalformat, uint @minlevel, uint @numlevels, uint @minlayer, uint @numlayers);
        void TrackMatrixNV(uint @target, uint @address, uint @matrix, uint @transform);
        void TransformFeedbackAttribsNV(int @count, int[] @attribs, uint @bufferMode);
        void TransformFeedbackBufferBase(uint @xfb, uint @index, uint @buffer);
        void TransformFeedbackBufferRange(uint @xfb, uint @index, uint @buffer, long @offset, long @size);
        void TransformFeedbackStreamAttribsNV(int @count, int[] @attribs, int @nbuffers, int[] @bufstreams, uint @bufferMode);
        void TransformFeedbackVaryings(uint @program, int @count, byte[][] @varyings, uint @bufferMode);
        void TransformFeedbackVaryingsEXT(uint @program, int @count, byte[][] @varyings, uint @bufferMode);
        void TransformFeedbackVaryingsNV(uint @program, int @count, int[] @locations, uint @bufferMode);
        void TransformPathNV(uint @resultPath, uint @srcPath, GlPathTransformType @transformType, float[] @transformValues);
        void Translated(double @x, double @y, double @z);
        void Translatef(float @x, float @y, float @z);
        void Translatex(int @x, int @y, int @z);
        void TranslatexOES(int @x, int @y, int @z);
        void Uniform1d(int @location, double @x);
        void Uniform1dv(int @location, int @count, double[] @value);
        void Uniform1f(int @location, float @v0);
        void Uniform1fARB(int @location, float @v0);
        void Uniform1fv(int @location, int @count, float[] @value);
        void Uniform1fvARB(int @location, int @count, float[] @value);
        void Uniform1i(int @location, int @v0);
        void Uniform1i64ARB(int @location, long @x);
        void Uniform1i64NV(int @location, long @x);
        void Uniform1i64vARB(int @location, int @count, long[] @value);
        void Uniform1i64vNV(int @location, int @count, long[] @value);
        void Uniform1iARB(int @location, int @v0);
        void Uniform1iv(int @location, int @count, int[] @value);
        void Uniform1ivARB(int @location, int @count, int[] @value);
        void Uniform1ui(int @location, uint @v0);
        void Uniform1ui64ARB(int @location, ulong @x);
        void Uniform1ui64NV(int @location, ulong @x);
        void Uniform1ui64vARB(int @location, int @count, ulong[] @value);
        void Uniform1ui64vNV(int @location, int @count, ulong[] @value);
        void Uniform1uiEXT(int @location, uint @v0);
        void Uniform1uiv(int @location, int @count, uint[] @value);
        void Uniform1uivEXT(int @location, int @count, uint[] @value);
        void Uniform2d(int @location, double @x, double @y);
        void Uniform2dv(int @location, int @count, double[] @value);
        void Uniform2f(int @location, float @v0, float @v1);
        void Uniform2fARB(int @location, float @v0, float @v1);
        void Uniform2fv(int @location, int @count, float[] @value);
        void Uniform2fvARB(int @location, int @count, float[] @value);
        void Uniform2i(int @location, int @v0, int @v1);
        void Uniform2i64ARB(int @location, long @x, long @y);
        void Uniform2i64NV(int @location, long @x, long @y);
        void Uniform2i64vARB(int @location, int @count, long[] @value);
        void Uniform2i64vNV(int @location, int @count, long[] @value);
        void Uniform2iARB(int @location, int @v0, int @v1);
        void Uniform2iv(int @location, int @count, int[] @value);
        void Uniform2ivARB(int @location, int @count, int[] @value);
        void Uniform2ui(int @location, uint @v0, uint @v1);
        void Uniform2ui64ARB(int @location, ulong @x, ulong @y);
        void Uniform2ui64NV(int @location, ulong @x, ulong @y);
        void Uniform2ui64vARB(int @location, int @count, ulong[] @value);
        void Uniform2ui64vNV(int @location, int @count, ulong[] @value);
        void Uniform2uiEXT(int @location, uint @v0, uint @v1);
        void Uniform2uiv(int @location, int @count, uint[] @value);
        void Uniform2uivEXT(int @location, int @count, uint[] @value);
        void Uniform3d(int @location, double @x, double @y, double @z);
        void Uniform3dv(int @location, int @count, double[] @value);
        void Uniform3f(int @location, float @v0, float @v1, float @v2);
        void Uniform3fARB(int @location, float @v0, float @v1, float @v2);
        void Uniform3fv(int @location, int @count, float[] @value);
        void Uniform3fvARB(int @location, int @count, float[] @value);
        void Uniform3i(int @location, int @v0, int @v1, int @v2);
        void Uniform3i64ARB(int @location, long @x, long @y, long @z);
        void Uniform3i64NV(int @location, long @x, long @y, long @z);
        void Uniform3i64vARB(int @location, int @count, long[] @value);
        void Uniform3i64vNV(int @location, int @count, long[] @value);
        void Uniform3iARB(int @location, int @v0, int @v1, int @v2);
        void Uniform3iv(int @location, int @count, int[] @value);
        void Uniform3ivARB(int @location, int @count, int[] @value);
        void Uniform3ui(int @location, uint @v0, uint @v1, uint @v2);
        void Uniform3ui64ARB(int @location, ulong @x, ulong @y, ulong @z);
        void Uniform3ui64NV(int @location, ulong @x, ulong @y, ulong @z);
        void Uniform3ui64vARB(int @location, int @count, ulong[] @value);
        void Uniform3ui64vNV(int @location, int @count, ulong[] @value);
        void Uniform3uiEXT(int @location, uint @v0, uint @v1, uint @v2);
        void Uniform3uiv(int @location, int @count, uint[] @value);
        void Uniform3uivEXT(int @location, int @count, uint[] @value);
        void Uniform4d(int @location, double @x, double @y, double @z, double @w);
        void Uniform4dv(int @location, int @count, double[] @value);
        void Uniform4f(int @location, float @v0, float @v1, float @v2, float @v3);
        void Uniform4fARB(int @location, float @v0, float @v1, float @v2, float @v3);
        void Uniform4fv(int @location, int @count, float[] @value);
        void Uniform4fvARB(int @location, int @count, float[] @value);
        void Uniform4i(int @location, int @v0, int @v1, int @v2, int @v3);
        void Uniform4i64ARB(int @location, long @x, long @y, long @z, long @w);
        void Uniform4i64NV(int @location, long @x, long @y, long @z, long @w);
        void Uniform4i64vARB(int @location, int @count, long[] @value);
        void Uniform4i64vNV(int @location, int @count, long[] @value);
        void Uniform4iARB(int @location, int @v0, int @v1, int @v2, int @v3);
        void Uniform4iv(int @location, int @count, int[] @value);
        void Uniform4ivARB(int @location, int @count, int[] @value);
        void Uniform4ui(int @location, uint @v0, uint @v1, uint @v2, uint @v3);
        void Uniform4ui64ARB(int @location, ulong @x, ulong @y, ulong @z, ulong @w);
        void Uniform4ui64NV(int @location, ulong @x, ulong @y, ulong @z, ulong @w);
        void Uniform4ui64vARB(int @location, int @count, ulong[] @value);
        void Uniform4ui64vNV(int @location, int @count, ulong[] @value);
        void Uniform4uiEXT(int @location, uint @v0, uint @v1, uint @v2, uint @v3);
        void Uniform4uiv(int @location, int @count, uint[] @value);
        void Uniform4uivEXT(int @location, int @count, uint[] @value);
        void UniformBlockBinding(uint @program, uint @uniformBlockIndex, uint @uniformBlockBinding);
        void UniformBufferEXT(uint @program, int @location, uint @buffer);
        void UniformHandleui64ARB(int @location, ulong @value);
        void UniformHandleui64IMG(int @location, ulong @value);
        void UniformHandleui64NV(int @location, ulong @value);
        void UniformHandleui64vARB(int @location, int @count, ulong[] @value);
        void UniformHandleui64vIMG(int @location, int @count, ulong[] @value);
        void UniformHandleui64vNV(int @location, int @count, ulong[] @value);
        void UniformMatrix2dv(int @location, int @count, GlBoolean @transpose, double[] @value);
        void UniformMatrix2fv(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformMatrix2fvARB(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformMatrix2x3dv(int @location, int @count, GlBoolean @transpose, double[] @value);
        void UniformMatrix2x3fv(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformMatrix2x3fvNV(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformMatrix2x4dv(int @location, int @count, GlBoolean @transpose, double[] @value);
        void UniformMatrix2x4fv(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformMatrix2x4fvNV(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformMatrix3dv(int @location, int @count, GlBoolean @transpose, double[] @value);
        void UniformMatrix3fv(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformMatrix3fvARB(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformMatrix3x2dv(int @location, int @count, GlBoolean @transpose, double[] @value);
        void UniformMatrix3x2fv(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformMatrix3x2fvNV(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformMatrix3x4dv(int @location, int @count, GlBoolean @transpose, double[] @value);
        void UniformMatrix3x4fv(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformMatrix3x4fvNV(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformMatrix4dv(int @location, int @count, GlBoolean @transpose, double[] @value);
        void UniformMatrix4fv(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformMatrix4fvARB(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformMatrix4x2dv(int @location, int @count, GlBoolean @transpose, double[] @value);
        void UniformMatrix4x2fv(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformMatrix4x2fvNV(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformMatrix4x3dv(int @location, int @count, GlBoolean @transpose, double[] @value);
        void UniformMatrix4x3fv(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformMatrix4x3fvNV(int @location, int @count, GlBoolean @transpose, float[] @value);
        void UniformSubroutinesuiv(GlShaderType @shadertype, int @count, uint[] @indices);
        void Uniformui64NV(int @location, ulong @value);
        void Uniformui64vNV(int @location, int @count, ulong[] @value);
        void UnlockArraysEXT();
        bool UnmapBuffer(GlBufferTargetARB @target);
        bool UnmapBufferARB(GlBufferTargetARB @target);
        bool UnmapBufferOES(uint @target);
        bool UnmapNamedBuffer(uint @buffer);
        bool UnmapNamedBufferEXT(uint @buffer);
        void UnmapObjectBufferATI(uint @buffer);
        void UnmapTexture2DINTEL(uint @texture, int @level);
        void UpdateObjectBufferATI(uint @buffer, uint @offset, int @size, byte[] @pointer, uint @preserve);
        void UseProgram(uint @program);
        void UseProgramObjectARB(IntPtr @programObj);
        void UseProgramStages(uint @pipeline, GlUseProgramStageMask @stages, uint @program);
        void UseProgramStagesEXT(uint @pipeline, GlUseProgramStageMask @stages, uint @program);
        void UseShaderProgramEXT(uint @type, uint @program);
        void VDPAUFiniNV();
        void VDPAUGetSurfaceivNV(long @surface, uint @pname, int @bufSize, int[] @length, int[] @values);
        void VDPAUInitNV(byte[] @vdpDevice, byte[] @getProcAddress);
        bool VDPAUIsSurfaceNV(long @surface);
        void VDPAUMapSurfacesNV(int @numSurfaces, long[] @surfaces);
        long VDPAURegisterOutputSurfaceNV(byte[] @vdpSurface, uint @target, int @numTextureNames, uint[] @textureNames);
        long VDPAURegisterVideoSurfaceNV(byte[] @vdpSurface, uint @target, int @numTextureNames, uint[] @textureNames);
        void VDPAUSurfaceAccessNV(long @surface, uint @access);
        void VDPAUUnmapSurfacesNV(int @numSurface, long[] @surfaces);
        void VDPAUUnregisterSurfaceNV(long @surface);
        void ValidateProgram(uint @program);
        void ValidateProgramARB(IntPtr @programObj);
        void ValidateProgramPipeline(uint @pipeline);
        void ValidateProgramPipelineEXT(uint @pipeline);
        void VariantArrayObjectATI(uint @id, uint @type, int @stride, uint @buffer, uint @offset);
        void VariantPointerEXT(uint @id, uint @type, uint @stride, byte[] @addr);
        void VariantbvEXT(uint @id, sbyte[] @addr);
        void VariantdvEXT(uint @id, double[] @addr);
        void VariantfvEXT(uint @id, float[] @addr);
        void VariantivEXT(uint @id, int[] @addr);
        void VariantsvEXT(uint @id, short[] @addr);
        void VariantubvEXT(uint @id, byte[] @addr);
        void VariantuivEXT(uint @id, uint[] @addr);
        void VariantusvEXT(uint @id, ushort[] @addr);
        void Vertex2bOES(sbyte @x, sbyte @y);
        void Vertex2bvOES(sbyte[] @coords);
        void Vertex2d(double @x, double @y);
        void Vertex2dv(double[] @v);
        void Vertex2f(float @x, float @y);
        void Vertex2fv(float[] @v);
        void Vertex2hNV(ushort @x, ushort @y);
        void Vertex2hvNV(ushort[] @v);
        void Vertex2i(int @x, int @y);
        void Vertex2iv(int[] @v);
        void Vertex2s(short @x, short @y);
        void Vertex2sv(short[] @v);
        void Vertex2xOES(int @x);
        void Vertex2xvOES(int[] @coords);
        void Vertex3bOES(sbyte @x, sbyte @y, sbyte @z);
        void Vertex3bvOES(sbyte[] @coords);
        void Vertex3d(double @x, double @y, double @z);
        void Vertex3dv(double[] @v);
        void Vertex3f(float @x, float @y, float @z);
        void Vertex3fv(float[] @v);
        void Vertex3hNV(ushort @x, ushort @y, ushort @z);
        void Vertex3hvNV(ushort[] @v);
        void Vertex3i(int @x, int @y, int @z);
        void Vertex3iv(int[] @v);
        void Vertex3s(short @x, short @y, short @z);
        void Vertex3sv(short[] @v);
        void Vertex3xOES(int @x, int @y);
        void Vertex3xvOES(int[] @coords);
        void Vertex4bOES(sbyte @x, sbyte @y, sbyte @z, sbyte @w);
        void Vertex4bvOES(sbyte[] @coords);
        void Vertex4d(double @x, double @y, double @z, double @w);
        void Vertex4dv(double[] @v);
        void Vertex4f(float @x, float @y, float @z, float @w);
        void Vertex4fv(float[] @v);
        void Vertex4hNV(ushort @x, ushort @y, ushort @z, ushort @w);
        void Vertex4hvNV(ushort[] @v);
        void Vertex4i(int @x, int @y, int @z, int @w);
        void Vertex4iv(int[] @v);
        void Vertex4s(short @x, short @y, short @z, short @w);
        void Vertex4sv(short[] @v);
        void Vertex4xOES(int @x, int @y, int @z);
        void Vertex4xvOES(int[] @coords);
        void VertexArrayAttribBinding(uint @vaobj, uint @attribindex, uint @bindingindex);
        void VertexArrayAttribFormat(uint @vaobj, uint @attribindex, int @size, GlVertexAttribType @type, bool @normalized, uint @relativeoffset);
        void VertexArrayAttribIFormat(uint @vaobj, uint @attribindex, int @size, GlVertexAttribType @type, uint @relativeoffset);
        void VertexArrayAttribLFormat(uint @vaobj, uint @attribindex, int @size, GlVertexAttribType @type, uint @relativeoffset);
        void VertexArrayBindVertexBufferEXT(uint @vaobj, uint @bindingindex, uint @buffer, long @offset, int @stride);
        void VertexArrayBindingDivisor(uint @vaobj, uint @bindingindex, uint @divisor);
        void VertexArrayColorOffsetEXT(uint @vaobj, uint @buffer, int @size, GlColorPointerType @type, int @stride, long @offset);
        void VertexArrayEdgeFlagOffsetEXT(uint @vaobj, uint @buffer, int @stride, long @offset);
        void VertexArrayElementBuffer(uint @vaobj, uint @buffer);
        void VertexArrayFogCoordOffsetEXT(uint @vaobj, uint @buffer, GlFogCoordinatePointerType @type, int @stride, long @offset);
        void VertexArrayIndexOffsetEXT(uint @vaobj, uint @buffer, GlIndexPointerType @type, int @stride, long @offset);
        void VertexArrayMultiTexCoordOffsetEXT(uint @vaobj, uint @buffer, uint @texunit, int @size, GlTexCoordPointerType @type, int @stride, long @offset);
        void VertexArrayNormalOffsetEXT(uint @vaobj, uint @buffer, GlNormalPointerType @type, int @stride, long @offset);
        void VertexArrayParameteriAPPLE(uint @pname, int @param);
        void VertexArrayRangeAPPLE(int @length, byte[] @pointer);
        void VertexArrayRangeNV(int @length, byte[] @pointer);
        void VertexArraySecondaryColorOffsetEXT(uint @vaobj, uint @buffer, int @size, GlColorPointerType @type, int @stride, long @offset);
        void VertexArrayTexCoordOffsetEXT(uint @vaobj, uint @buffer, int @size, GlTexCoordPointerType @type, int @stride, long @offset);
        void VertexArrayVertexAttribBindingEXT(uint @vaobj, uint @attribindex, uint @bindingindex);
        void VertexArrayVertexAttribDivisorEXT(uint @vaobj, uint @index, uint @divisor);
        void VertexArrayVertexAttribFormatEXT(uint @vaobj, uint @attribindex, int @size, uint @type, GlBoolean @normalized, uint @relativeoffset);
        void VertexArrayVertexAttribIFormatEXT(uint @vaobj, uint @attribindex, int @size, uint @type, uint @relativeoffset);
        void VertexArrayVertexAttribIOffsetEXT(uint @vaobj, uint @buffer, uint @index, int @size, GlVertexAttribEnum @type, int @stride, long @offset);
        void VertexArrayVertexAttribLFormatEXT(uint @vaobj, uint @attribindex, int @size, uint @type, uint @relativeoffset);
        void VertexArrayVertexAttribLOffsetEXT(uint @vaobj, uint @buffer, uint @index, int @size, uint @type, int @stride, long @offset);
        void VertexArrayVertexAttribOffsetEXT(uint @vaobj, uint @buffer, uint @index, int @size, GlVertexAttribPointerType @type, bool @normalized, int @stride, long @offset);
        void VertexArrayVertexBindingDivisorEXT(uint @vaobj, uint @bindingindex, uint @divisor);
        void VertexArrayVertexBuffer(uint @vaobj, uint @bindingindex, uint @buffer, long @offset, int @stride);
        void VertexArrayVertexBuffers(uint @vaobj, uint @first, int @count, uint[] @buffers, long[] @offsets, int[] @strides);
        void VertexArrayVertexOffsetEXT(uint @vaobj, uint @buffer, int @size, GlVertexPointerType @type, int @stride, long @offset);
        void VertexAttrib1d(uint @index, double @x);
        void VertexAttrib1dARB(uint @index, double @x);
        void VertexAttrib1dNV(uint @index, double @x);
        void VertexAttrib1dv(uint @index, double[] @v);
        void VertexAttrib1dvARB(uint @index, double[] @v);
        void VertexAttrib1dvNV(uint @index, double[] @v);
        void VertexAttrib1f(uint @index, float @x);
        void VertexAttrib1fARB(uint @index, float @x);
        void VertexAttrib1fNV(uint @index, float @x);
        void VertexAttrib1fv(uint @index, float[] @v);
        void VertexAttrib1fvARB(uint @index, float[] @v);
        void VertexAttrib1fvNV(uint @index, float[] @v);
        void VertexAttrib1hNV(uint @index, ushort @x);
        void VertexAttrib1hvNV(uint @index, ushort[] @v);
        void VertexAttrib1s(uint @index, short @x);
        void VertexAttrib1sARB(uint @index, short @x);
        void VertexAttrib1sNV(uint @index, short @x);
        void VertexAttrib1sv(uint @index, short[] @v);
        void VertexAttrib1svARB(uint @index, short[] @v);
        void VertexAttrib1svNV(uint @index, short[] @v);
        void VertexAttrib2d(uint @index, double @x, double @y);
        void VertexAttrib2dARB(uint @index, double @x, double @y);
        void VertexAttrib2dNV(uint @index, double @x, double @y);
        void VertexAttrib2dv(uint @index, double[] @v);
        void VertexAttrib2dvARB(uint @index, double[] @v);
        void VertexAttrib2dvNV(uint @index, double[] @v);
        void VertexAttrib2f(uint @index, float @x, float @y);
        void VertexAttrib2fARB(uint @index, float @x, float @y);
        void VertexAttrib2fNV(uint @index, float @x, float @y);
        void VertexAttrib2fv(uint @index, float[] @v);
        void VertexAttrib2fvARB(uint @index, float[] @v);
        void VertexAttrib2fvNV(uint @index, float[] @v);
        void VertexAttrib2hNV(uint @index, ushort @x, ushort @y);
        void VertexAttrib2hvNV(uint @index, ushort[] @v);
        void VertexAttrib2s(uint @index, short @x, short @y);
        void VertexAttrib2sARB(uint @index, short @x, short @y);
        void VertexAttrib2sNV(uint @index, short @x, short @y);
        void VertexAttrib2sv(uint @index, short[] @v);
        void VertexAttrib2svARB(uint @index, short[] @v);
        void VertexAttrib2svNV(uint @index, short[] @v);
        void VertexAttrib3d(uint @index, double @x, double @y, double @z);
        void VertexAttrib3dARB(uint @index, double @x, double @y, double @z);
        void VertexAttrib3dNV(uint @index, double @x, double @y, double @z);
        void VertexAttrib3dv(uint @index, double[] @v);
        void VertexAttrib3dvARB(uint @index, double[] @v);
        void VertexAttrib3dvNV(uint @index, double[] @v);
        void VertexAttrib3f(uint @index, float @x, float @y, float @z);
        void VertexAttrib3fARB(uint @index, float @x, float @y, float @z);
        void VertexAttrib3fNV(uint @index, float @x, float @y, float @z);
        void VertexAttrib3fv(uint @index, float[] @v);
        void VertexAttrib3fvARB(uint @index, float[] @v);
        void VertexAttrib3fvNV(uint @index, float[] @v);
        void VertexAttrib3hNV(uint @index, ushort @x, ushort @y, ushort @z);
        void VertexAttrib3hvNV(uint @index, ushort[] @v);
        void VertexAttrib3s(uint @index, short @x, short @y, short @z);
        void VertexAttrib3sARB(uint @index, short @x, short @y, short @z);
        void VertexAttrib3sNV(uint @index, short @x, short @y, short @z);
        void VertexAttrib3sv(uint @index, short[] @v);
        void VertexAttrib3svARB(uint @index, short[] @v);
        void VertexAttrib3svNV(uint @index, short[] @v);
        void VertexAttrib4Nbv(uint @index, sbyte[] @v);
        void VertexAttrib4NbvARB(uint @index, sbyte[] @v);
        void VertexAttrib4Niv(uint @index, int[] @v);
        void VertexAttrib4NivARB(uint @index, int[] @v);
        void VertexAttrib4Nsv(uint @index, short[] @v);
        void VertexAttrib4NsvARB(uint @index, short[] @v);
        void VertexAttrib4Nub(uint @index, byte @x, byte @y, byte @z, byte @w);
        void VertexAttrib4NubARB(uint @index, byte @x, byte @y, byte @z, byte @w);
        void VertexAttrib4Nubv(uint @index, byte[] @v);
        void VertexAttrib4NubvARB(uint @index, byte[] @v);
        void VertexAttrib4Nuiv(uint @index, uint[] @v);
        void VertexAttrib4NuivARB(uint @index, uint[] @v);
        void VertexAttrib4Nusv(uint @index, ushort[] @v);
        void VertexAttrib4NusvARB(uint @index, ushort[] @v);
        void VertexAttrib4bv(uint @index, sbyte[] @v);
        void VertexAttrib4bvARB(uint @index, sbyte[] @v);
        void VertexAttrib4d(uint @index, double @x, double @y, double @z, double @w);
        void VertexAttrib4dARB(uint @index, double @x, double @y, double @z, double @w);
        void VertexAttrib4dNV(uint @index, double @x, double @y, double @z, double @w);
        void VertexAttrib4dv(uint @index, double[] @v);
        void VertexAttrib4dvARB(uint @index, double[] @v);
        void VertexAttrib4dvNV(uint @index, double[] @v);
        void VertexAttrib4f(uint @index, float @x, float @y, float @z, float @w);
        void VertexAttrib4fARB(uint @index, float @x, float @y, float @z, float @w);
        void VertexAttrib4fNV(uint @index, float @x, float @y, float @z, float @w);
        void VertexAttrib4fv(uint @index, float[] @v);
        void VertexAttrib4fvARB(uint @index, float[] @v);
        void VertexAttrib4fvNV(uint @index, float[] @v);
        void VertexAttrib4hNV(uint @index, ushort @x, ushort @y, ushort @z, ushort @w);
        void VertexAttrib4hvNV(uint @index, ushort[] @v);
        void VertexAttrib4iv(uint @index, int[] @v);
        void VertexAttrib4ivARB(uint @index, int[] @v);
        void VertexAttrib4s(uint @index, short @x, short @y, short @z, short @w);
        void VertexAttrib4sARB(uint @index, short @x, short @y, short @z, short @w);
        void VertexAttrib4sNV(uint @index, short @x, short @y, short @z, short @w);
        void VertexAttrib4sv(uint @index, short[] @v);
        void VertexAttrib4svARB(uint @index, short[] @v);
        void VertexAttrib4svNV(uint @index, short[] @v);
        void VertexAttrib4ubNV(uint @index, byte @x, byte @y, byte @z, byte @w);
        void VertexAttrib4ubv(uint @index, byte[] @v);
        void VertexAttrib4ubvARB(uint @index, byte[] @v);
        void VertexAttrib4ubvNV(uint @index, byte[] @v);
        void VertexAttrib4uiv(uint @index, uint[] @v);
        void VertexAttrib4uivARB(uint @index, uint[] @v);
        void VertexAttrib4usv(uint @index, ushort[] @v);
        void VertexAttrib4usvARB(uint @index, ushort[] @v);
        void VertexAttribArrayObjectATI(uint @index, int @size, GlVertexAttribPointerType @type, GlBoolean @normalized, int @stride, uint @buffer, uint @offset);
        void VertexAttribBinding(uint @attribindex, uint @bindingindex);
        void VertexAttribDivisor(uint @index, uint @divisor);
        void VertexAttribDivisorANGLE(uint @index, uint @divisor);
        void VertexAttribDivisorARB(uint @index, uint @divisor);
        void VertexAttribDivisorEXT(uint @index, uint @divisor);
        void VertexAttribDivisorNV(uint @index, uint @divisor);
        void VertexAttribFormat(uint @attribindex, int @size, uint @type, GlBoolean @normalized, uint @relativeoffset);
        void VertexAttribFormatNV(uint @index, int @size, uint @type, GlBoolean @normalized, int @stride);
        void VertexAttribI1i(uint @index, int @x);
        void VertexAttribI1iEXT(uint @index, int @x);
        void VertexAttribI1iv(uint @index, int[] @v);
        void VertexAttribI1ivEXT(uint @index, int[] @v);
        void VertexAttribI1ui(uint @index, uint @x);
        void VertexAttribI1uiEXT(uint @index, uint @x);
        void VertexAttribI1uiv(uint @index, uint[] @v);
        void VertexAttribI1uivEXT(uint @index, uint[] @v);
        void VertexAttribI2i(uint @index, int @x, int @y);
        void VertexAttribI2iEXT(uint @index, int @x, int @y);
        void VertexAttribI2iv(uint @index, int[] @v);
        void VertexAttribI2ivEXT(uint @index, int[] @v);
        void VertexAttribI2ui(uint @index, uint @x, uint @y);
        void VertexAttribI2uiEXT(uint @index, uint @x, uint @y);
        void VertexAttribI2uiv(uint @index, uint[] @v);
        void VertexAttribI2uivEXT(uint @index, uint[] @v);
        void VertexAttribI3i(uint @index, int @x, int @y, int @z);
        void VertexAttribI3iEXT(uint @index, int @x, int @y, int @z);
        void VertexAttribI3iv(uint @index, int[] @v);
        void VertexAttribI3ivEXT(uint @index, int[] @v);
        void VertexAttribI3ui(uint @index, uint @x, uint @y, uint @z);
        void VertexAttribI3uiEXT(uint @index, uint @x, uint @y, uint @z);
        void VertexAttribI3uiv(uint @index, uint[] @v);
        void VertexAttribI3uivEXT(uint @index, uint[] @v);
        void VertexAttribI4bv(uint @index, sbyte[] @v);
        void VertexAttribI4bvEXT(uint @index, sbyte[] @v);
        void VertexAttribI4i(uint @index, int @x, int @y, int @z, int @w);
        void VertexAttribI4iEXT(uint @index, int @x, int @y, int @z, int @w);
        void VertexAttribI4iv(uint @index, int[] @v);
        void VertexAttribI4ivEXT(uint @index, int[] @v);
        void VertexAttribI4sv(uint @index, short[] @v);
        void VertexAttribI4svEXT(uint @index, short[] @v);
        void VertexAttribI4ubv(uint @index, byte[] @v);
        void VertexAttribI4ubvEXT(uint @index, byte[] @v);
        void VertexAttribI4ui(uint @index, uint @x, uint @y, uint @z, uint @w);
        void VertexAttribI4uiEXT(uint @index, uint @x, uint @y, uint @z, uint @w);
        void VertexAttribI4uiv(uint @index, uint[] @v);
        void VertexAttribI4uivEXT(uint @index, uint[] @v);
        void VertexAttribI4usv(uint @index, ushort[] @v);
        void VertexAttribI4usvEXT(uint @index, ushort[] @v);
        void VertexAttribIFormat(uint @attribindex, int @size, uint @type, uint @relativeoffset);
        void VertexAttribIFormatNV(uint @index, int @size, uint @type, int @stride);
        void VertexAttribIPointer(uint @index, int @size, GlVertexAttribPointerType @type, int @stride, byte[] @pointer);
        void VertexAttribIPointerEXT(uint @index, int @size, GlVertexAttribPointerType @type, int @stride, byte[] @pointer);
        void VertexAttribL1d(uint @index, double @x);
        void VertexAttribL1dEXT(uint @index, double @x);
        void VertexAttribL1dv(uint @index, double[] @v);
        void VertexAttribL1dvEXT(uint @index, double[] @v);
        void VertexAttribL1i64NV(uint @index, long @x);
        void VertexAttribL1i64vNV(uint @index, long[] @v);
        void VertexAttribL1ui64ARB(uint @index, ulong @x);
        void VertexAttribL1ui64NV(uint @index, ulong @x);
        void VertexAttribL1ui64vARB(uint @index, ulong[] @v);
        void VertexAttribL1ui64vNV(uint @index, ulong[] @v);
        void VertexAttribL2d(uint @index, double @x, double @y);
        void VertexAttribL2dEXT(uint @index, double @x, double @y);
        void VertexAttribL2dv(uint @index, double[] @v);
        void VertexAttribL2dvEXT(uint @index, double[] @v);
        void VertexAttribL2i64NV(uint @index, long @x, long @y);
        void VertexAttribL2i64vNV(uint @index, long[] @v);
        void VertexAttribL2ui64NV(uint @index, ulong @x, ulong @y);
        void VertexAttribL2ui64vNV(uint @index, ulong[] @v);
        void VertexAttribL3d(uint @index, double @x, double @y, double @z);
        void VertexAttribL3dEXT(uint @index, double @x, double @y, double @z);
        void VertexAttribL3dv(uint @index, double[] @v);
        void VertexAttribL3dvEXT(uint @index, double[] @v);
        void VertexAttribL3i64NV(uint @index, long @x, long @y, long @z);
        void VertexAttribL3i64vNV(uint @index, long[] @v);
        void VertexAttribL3ui64NV(uint @index, ulong @x, ulong @y, ulong @z);
        void VertexAttribL3ui64vNV(uint @index, ulong[] @v);
        void VertexAttribL4d(uint @index, double @x, double @y, double @z, double @w);
        void VertexAttribL4dEXT(uint @index, double @x, double @y, double @z, double @w);
        void VertexAttribL4dv(uint @index, double[] @v);
        void VertexAttribL4dvEXT(uint @index, double[] @v);
        void VertexAttribL4i64NV(uint @index, long @x, long @y, long @z, long @w);
        void VertexAttribL4i64vNV(uint @index, long[] @v);
        void VertexAttribL4ui64NV(uint @index, ulong @x, ulong @y, ulong @z, ulong @w);
        void VertexAttribL4ui64vNV(uint @index, ulong[] @v);
        void VertexAttribLFormat(uint @attribindex, int @size, GlVertexAttribType @type, uint @relativeoffset);
        void VertexAttribLFormatNV(uint @index, int @size, GlVertexAttribType @type, int @stride);
        void VertexAttribLPointer(uint @index, int @size, GlVertexAttribPointerType @type, int @stride, byte[] @pointer);
        void VertexAttribLPointerEXT(uint @index, int @size, GlVertexAttribPointerType @type, int @stride, byte[] @pointer);
        void VertexAttribP1ui(uint @index, GlVertexAttribPointerType @type, GlBoolean @normalized, uint @value);
        void VertexAttribP1uiv(uint @index, GlVertexAttribPointerType @type, GlBoolean @normalized, uint[] @value);
        void VertexAttribP2ui(uint @index, GlVertexAttribPointerType @type, GlBoolean @normalized, uint @value);
        void VertexAttribP2uiv(uint @index, GlVertexAttribPointerType @type, GlBoolean @normalized, uint[] @value);
        void VertexAttribP3ui(uint @index, GlVertexAttribPointerType @type, GlBoolean @normalized, uint @value);
        void VertexAttribP3uiv(uint @index, GlVertexAttribPointerType @type, GlBoolean @normalized, uint[] @value);
        void VertexAttribP4ui(uint @index, GlVertexAttribPointerType @type, GlBoolean @normalized, uint @value);
        void VertexAttribP4uiv(uint @index, GlVertexAttribPointerType @type, GlBoolean @normalized, uint[] @value);
        void VertexAttribParameteriAMD(uint @index, uint @pname, int @param);
        void VertexAttribPointer(uint @index, int @size, GlVertexAttribPointerType @type, GlBoolean @normalized, int @stride, byte[] @pointer);
        void VertexAttribPointerARB(uint @index, int @size, GlVertexAttribPointerType @type, GlBoolean @normalized, int @stride, byte[] @pointer);
        void VertexAttribPointerNV(uint @index, int @fsize, uint @type, int @stride, byte[] @pointer);
        void VertexAttribs1dvNV(uint @index, int @count, double[] @v);
        void VertexAttribs1fvNV(uint @index, int @count, float[] @v);
        void VertexAttribs1hvNV(uint @index, int @n, ushort[] @v);
        void VertexAttribs1svNV(uint @index, int @count, short[] @v);
        void VertexAttribs2dvNV(uint @index, int @count, double[] @v);
        void VertexAttribs2fvNV(uint @index, int @count, float[] @v);
        void VertexAttribs2hvNV(uint @index, int @n, ushort[] @v);
        void VertexAttribs2svNV(uint @index, int @count, short[] @v);
        void VertexAttribs3dvNV(uint @index, int @count, double[] @v);
        void VertexAttribs3fvNV(uint @index, int @count, float[] @v);
        void VertexAttribs3hvNV(uint @index, int @n, ushort[] @v);
        void VertexAttribs3svNV(uint @index, int @count, short[] @v);
        void VertexAttribs4dvNV(uint @index, int @count, double[] @v);
        void VertexAttribs4fvNV(uint @index, int @count, float[] @v);
        void VertexAttribs4hvNV(uint @index, int @n, ushort[] @v);
        void VertexAttribs4svNV(uint @index, int @count, short[] @v);
        void VertexAttribs4ubvNV(uint @index, int @count, byte[] @v);
        void VertexBindingDivisor(uint @bindingindex, uint @divisor);
        void VertexBlendARB(int @count);
        void VertexBlendEnvfATI(uint @pname, float @param);
        void VertexBlendEnviATI(uint @pname, int @param);
        void VertexFormatNV(int @size, GlVertexPointerType @type, int @stride);
        void VertexP2ui(GlVertexPointerType @type, uint @value);
        void VertexP2uiv(GlVertexPointerType @type, uint[] @value);
        void VertexP3ui(GlVertexPointerType @type, uint @value);
        void VertexP3uiv(GlVertexPointerType @type, uint[] @value);
        void VertexP4ui(GlVertexPointerType @type, uint @value);
        void VertexP4uiv(GlVertexPointerType @type, uint[] @value);
        void VertexPointer(int @size, GlVertexPointerType @type, int @stride, byte[] @pointer);
        void VertexPointerEXT(int @size, GlVertexPointerType @type, int @stride, int @count, byte[] @pointer);
        void VertexPointerListIBM(int @size, GlVertexPointerType @type, int @stride, byte[][] @pointer, int @ptrstride);
        void VertexPointervINTEL(int @size, GlVertexPointerType @type, byte[][] @pointer);
        void VertexStream1dATI(uint @stream, double @x);
        void VertexStream1dvATI(uint @stream, double[] @coords);
        void VertexStream1fATI(uint @stream, float @x);
        void VertexStream1fvATI(uint @stream, float[] @coords);
        void VertexStream1iATI(uint @stream, int @x);
        void VertexStream1ivATI(uint @stream, int[] @coords);
        void VertexStream1sATI(uint @stream, short @x);
        void VertexStream1svATI(uint @stream, short[] @coords);
        void VertexStream2dATI(uint @stream, double @x, double @y);
        void VertexStream2dvATI(uint @stream, double[] @coords);
        void VertexStream2fATI(uint @stream, float @x, float @y);
        void VertexStream2fvATI(uint @stream, float[] @coords);
        void VertexStream2iATI(uint @stream, int @x, int @y);
        void VertexStream2ivATI(uint @stream, int[] @coords);
        void VertexStream2sATI(uint @stream, short @x, short @y);
        void VertexStream2svATI(uint @stream, short[] @coords);
        void VertexStream3dATI(uint @stream, double @x, double @y, double @z);
        void VertexStream3dvATI(uint @stream, double[] @coords);
        void VertexStream3fATI(uint @stream, float @x, float @y, float @z);
        void VertexStream3fvATI(uint @stream, float[] @coords);
        void VertexStream3iATI(uint @stream, int @x, int @y, int @z);
        void VertexStream3ivATI(uint @stream, int[] @coords);
        void VertexStream3sATI(uint @stream, short @x, short @y, short @z);
        void VertexStream3svATI(uint @stream, short[] @coords);
        void VertexStream4dATI(uint @stream, double @x, double @y, double @z, double @w);
        void VertexStream4dvATI(uint @stream, double[] @coords);
        void VertexStream4fATI(uint @stream, float @x, float @y, float @z, float @w);
        void VertexStream4fvATI(uint @stream, float[] @coords);
        void VertexStream4iATI(uint @stream, int @x, int @y, int @z, int @w);
        void VertexStream4ivATI(uint @stream, int[] @coords);
        void VertexStream4sATI(uint @stream, short @x, short @y, short @z, short @w);
        void VertexStream4svATI(uint @stream, short[] @coords);
        void VertexWeightPointerEXT(int @size, uint @type, int @stride, byte[] @pointer);
        void VertexWeightfEXT(float @weight);
        void VertexWeightfvEXT(float[] @weight);
        void VertexWeighthNV(ushort @weight);
        void VertexWeighthvNV(ushort[] @weight);
        uint VideoCaptureNV(uint @video_capture_slot, uint[] @sequence_num, ulong[] @capture_time);
        void VideoCaptureStreamParameterdvNV(uint @video_capture_slot, uint @stream, uint @pname, double[] @params);
        void VideoCaptureStreamParameterfvNV(uint @video_capture_slot, uint @stream, uint @pname, float[] @params);
        void VideoCaptureStreamParameterivNV(uint @video_capture_slot, uint @stream, uint @pname, int[] @params);
        void Viewport(int @x, int @y, int @width, int @height);
        void ViewportArrayv(uint @first, int @count, float[] @v);
        void ViewportArrayvNV(uint @first, int @count, float[] @v);
        void ViewportArrayvOES(uint @first, int @count, float[] @v);
        void ViewportIndexedf(uint @index, float @x, float @y, float @w, float @h);
        void ViewportIndexedfOES(uint @index, float @x, float @y, float @w, float @h);
        void ViewportIndexedfNV(uint @index, float @x, float @y, float @w, float @h);
        void ViewportIndexedfv(uint @index, float[] @v);
        void ViewportIndexedfvOES(uint @index, float[] @v);
        void ViewportIndexedfvNV(uint @index, float[] @v);
        void ViewportPositionWScaleNV(uint @index, float @xcoeff, float @ycoeff);
        void ViewportSwizzleNV(uint @index, uint @swizzlex, uint @swizzley, uint @swizzlez, uint @swizzlew);
        void WaitSemaphoreEXT(uint @semaphore, uint @numBufferBarriers, uint[] @buffers, uint @numTextureBarriers, uint[] @textures, GlTextureLayout[] @srcLayouts);
        void WaitSync(IntPtr @sync, uint @flags, ulong @timeout);
        void WaitSyncAPPLE(IntPtr @sync, uint @flags, ulong @timeout);
        void WeightPathsNV(uint @resultPath, int @numPaths, uint[] @paths, float[] @weights);
        void WeightPointerARB(int @size, uint @type, int @stride, byte[] @pointer);
        void WeightPointerOES(int @size, uint @type, int @stride, byte[] @pointer);
        void WeightbvARB(int @size, sbyte[] @weights);
        void WeightdvARB(int @size, double[] @weights);
        void WeightfvARB(int @size, float[] @weights);
        void WeightivARB(int @size, int[] @weights);
        void WeightsvARB(int @size, short[] @weights);
        void WeightubvARB(int @size, byte[] @weights);
        void WeightuivARB(int @size, uint[] @weights);
        void WeightusvARB(int @size, ushort[] @weights);
        void WindowPos2d(double @x, double @y);
        void WindowPos2dARB(double @x, double @y);
        void WindowPos2dMESA(double @x, double @y);
        void WindowPos2dv(double[] @v);
        void WindowPos2dvARB(double[] @v);
        void WindowPos2dvMESA(double[] @v);
        void WindowPos2f(float @x, float @y);
        void WindowPos2fARB(float @x, float @y);
        void WindowPos2fMESA(float @x, float @y);
        void WindowPos2fv(float[] @v);
        void WindowPos2fvARB(float[] @v);
        void WindowPos2fvMESA(float[] @v);
        void WindowPos2i(int @x, int @y);
        void WindowPos2iARB(int @x, int @y);
        void WindowPos2iMESA(int @x, int @y);
        void WindowPos2iv(int[] @v);
        void WindowPos2ivARB(int[] @v);
        void WindowPos2ivMESA(int[] @v);
        void WindowPos2s(short @x, short @y);
        void WindowPos2sARB(short @x, short @y);
        void WindowPos2sMESA(short @x, short @y);
        void WindowPos2sv(short[] @v);
        void WindowPos2svARB(short[] @v);
        void WindowPos2svMESA(short[] @v);
        void WindowPos3d(double @x, double @y, double @z);
        void WindowPos3dARB(double @x, double @y, double @z);
        void WindowPos3dMESA(double @x, double @y, double @z);
        void WindowPos3dv(double[] @v);
        void WindowPos3dvARB(double[] @v);
        void WindowPos3dvMESA(double[] @v);
        void WindowPos3f(float @x, float @y, float @z);
        void WindowPos3fARB(float @x, float @y, float @z);
        void WindowPos3fMESA(float @x, float @y, float @z);
        void WindowPos3fv(float[] @v);
        void WindowPos3fvARB(float[] @v);
        void WindowPos3fvMESA(float[] @v);
        void WindowPos3i(int @x, int @y, int @z);
        void WindowPos3iARB(int @x, int @y, int @z);
        void WindowPos3iMESA(int @x, int @y, int @z);
        void WindowPos3iv(int[] @v);
        void WindowPos3ivARB(int[] @v);
        void WindowPos3ivMESA(int[] @v);
        void WindowPos3s(short @x, short @y, short @z);
        void WindowPos3sARB(short @x, short @y, short @z);
        void WindowPos3sMESA(short @x, short @y, short @z);
        void WindowPos3sv(short[] @v);
        void WindowPos3svARB(short[] @v);
        void WindowPos3svMESA(short[] @v);
        void WindowPos4dMESA(double @x, double @y, double @z, double @w);
        void WindowPos4dvMESA(double[] @v);
        void WindowPos4fMESA(float @x, float @y, float @z, float @w);
        void WindowPos4fvMESA(float[] @v);
        void WindowPos4iMESA(int @x, int @y, int @z, int @w);
        void WindowPos4ivMESA(int[] @v);
        void WindowPos4sMESA(short @x, short @y, short @z, short @w);
        void WindowPos4svMESA(short[] @v);
        void WindowRectanglesEXT(uint @mode, int @count, int[] @box);
        void WriteMaskEXT(uint @res, uint @in, uint @outX, uint @outY, uint @outZ, uint @outW);
        void DrawVkImageNV(ulong @vkImage, uint @sampler, float @x0, float @y0, float @x1, float @y1, float @z, float @s0, float @t0, float @s1, float @t1);
        IntPtr GetVkProcAddrNV(byte[] @name);
        void WaitVkSemaphoreNV(ulong @vkSemaphore);
        void SignalVkSemaphoreNV(ulong @vkSemaphore);
        void SignalVkFenceNV(ulong @vkFence);
    }
}
