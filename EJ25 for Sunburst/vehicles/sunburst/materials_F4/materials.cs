singleton Material(sbr_lettering)
{
    mapTo = "sbr_lettering";
    specularMap[0] = "vehicles/sbr/sbr_lettering_s.dds";
    normalMap[0] = "vehicles/sbr/sbr_lettering_n.dds";
    diffuseMap[0] = "vehicles/sbr/sbr_lettering_d.dds";
    reflectivityMap[0] = "vehicles/sbr/sbr_lettering_s.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1 1 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    //translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle"; materialTag2 = "decal";
    //translucentZWrite = "1";
};

singleton Material(sbr)
{
    mapTo = "sbr";
    diffuseMap[2] = "vehicles/sbr/sbr_c.dds";
    specularMap[2] = "vehicles/sbr/sbr_s.dds";
    normalMap[2] = "vehicles/sbr/sbr_n.dds";
    diffuseMap[1] = "vehicles/sbr/sbr_d.dds";
    specularMap[1] = "vehicles/sbr/sbr_s.dds";
    normalMap[1] = "vehicles/sbr/sbr_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/sbr/sbr_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    specularColor[0] = "1 1 1 1";
    specularColor[1] = "1 1 1 1";
    specularColor[2] = "1 1 1 1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    instanceDiffuse[2] = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sbr_widebody)
{
    mapTo = "sbr_widebody";
    diffuseMap[2] = "vehicles/sbr/sbr_widebody_c.dds";
    specularMap[2] = "vehicles/sbr/sbr_widebody_s.dds";
    normalMap[2] = "vehicles/sbr/sbr_widebody_n.dds";
    diffuseMap[1] = "vehicles/sbr/sbr_widebody_d.dds";
    specularMap[1] = "vehicles/sbr/sbr_widebody_s.dds";
    normalMap[1] = "vehicles/sbr/sbr_widebody_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/sbr/sbr_widebody_n.dds";
    specular[0] = "0.5 0.5 0.5 0.1";
    specular[1] = "0.5 0.5 0.5 0.1";
    specular[2] = "0.5 0.5 0.5 0.1";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    specularPower[2] = "128";
    pixelSpecular[2] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    diffuseColor[2] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    beamngDiffuseColorSlot = 2;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sbr_interior)
{
    mapTo = "sbr_interior";
    normalMap[0] = "vehicles/sbr/sbr_interior_n.dds";
    diffuseMap[0] = "vehicles/sbr/sbr_interior_d.dds";
    specularMap[0] = "vehicles/sbr/sbr_interior_s.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    cubemap = "global_cubemap_metalblurred";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sbr_screen)
{
    mapTo = "sbr_screen";
    diffuseMap[0] = "@screen_gps";
    specularMap[0] = "vehicles/common/null.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    useAnisotropic[0] = "1";
    castShadows = "1";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    emissive[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sbr_seats)
{
    mapTo = "sbr_seats";
    normalMap[0] = "vehicles/sbr/sbr_seats_n.dds";
    diffuseMap[0] = "vehicles/sbr/sbr_seats_d.dds";
    specularMap[0] = "vehicles/sbr/sbr_seats_s.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    useAnisotropic[0] = "1";
    castShadows = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sbr_gauges)
{
    mapTo = "sbr_gauges";
    diffuseMap[0] = "vehicles/sbr/sbr_gauges_d.dds";
    specularMap[0] = "vehicles/sbr/sbr_gauges_s.dds";
    normalMap[0] = "vehicles/sbr/sbr_gauges_n.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    cubemap = "global_cubemap_metalblurred";
};

singleton Material(sbr_gauges_on)
{
    mapTo = "sbr_gauges_on";
    diffuseMap[1] = "vehicles/sbr/sbr_gauges_g.dds";
    specularMap[1] = "vehicles/sbr/sbr_gauges_s.dds";
    normalMap[1] = "vehicles/sbr/sbr_gauges_n.dds";
    diffuseMap[0] = "vehicles/sbr/sbr_gauges_d.dds";
    specularMap[0] = "vehicles/sbr/sbr_gauges_s.dds";
    normalMap[0] = "vehicles/sbr/sbr_gauges_n.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    specularPower[1] = "32";
    pixelSpecular[0] = "1";
    useAnisotropic[0] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
    cubemap = "global_cubemap_metalblurred";
    emissive[1] = "1";
    diffuseColor[1] = "1 1 1 0.8";
    useAnisotropic[1] = "1";
};

singleton Material(sbr_display)
{
    mapTo = "sbr_display";
    diffuseMap[0] = "vehicles/sbr/sbr_display.dds";
    diffuseColor[0] = "1 1 1 1";
    specularPower[0] = "32";
    specularPower[1] = "32";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "0";
    translucentBlendOp = "None";
    alphaTest = "1";
    alphaRef = "20";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sbr_glass)
{
    mapTo = "sbr_glass";
    reflectivityMap[0] = "vehicles/common/glass_base.dds";
    diffuseMap[0] = "vehicles/sbr/sbr_glass_d.dds";
    opacityMap[0] = "vehicles/sbr/sbr_glass_d.dds";
    diffuseMap[1] = "vehicles/sbr/sbr_glass_da.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/common/null_n.dds";
    diffuseColor[1] = "0.5 0.5 0.5 0.75";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1.5 1.5 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sbr_glass_int)
{
    mapTo = "sbr_glass_int";
    diffuseMap[0] = "vehicles/sbr/sbr_glass_d.dds";
    specularMap[0] = "vehicles/common/null.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    diffuseColor[0] = "1 1.5 1.5 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    doubleSided = "0";
    alphaRef = "0";
    dynamicCubemap = false;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sbr_glass_dmg)
{
    mapTo = "sbr_glass_dmg";
    diffuseMap[0] = "vehicles/sbr/sbr_glass_dmg_d.dds";
    opacityMap[0] = "vehicles/sbr/sbr_glass_dmg_d.dds";
    specularMap[0] = "vehicles/common/glass_dmg_s.dds";
    normalMap[0] = "vehicles/common/glass_dmg_n.dds";
    diffuseMap[1] = "vehicles/sbr/sbr_glass_dmg_d.dds";
    specularMap[1] = "vehicles/common/glass_dmg_s.dds";
    normalMap[1] = "vehicles/common/glass_dmg_n.dds";
    specularPower[0] = "128";
    specularPower[1] = "128";
    diffuseColor[0] = "1 1 1 1.5";
    diffuseColor[1] = "1 1 1 0.75";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sbr_windshield_dmg)
{
    mapTo = "sbr_windshield_dmg";
    reflectivityMap[0] = "vehicles/common/glass_base.dds";
    diffuseMap[0] = "vehicles/sbr/sbr_glass_dmg_d.dds";
    specularMap[0] = "vehicles/common/glass_dmg_s.dds";
    normalMap[0] = "vehicles/common/windshield_dmg_n.dds";
    specularPower[0] = "32";
    diffuseColor[0] = "1.5 1.5 1.5 1";
    useAnisotropic[0] = "1";
    castShadows = "0";
    translucent = "1";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sbr_engine)
{
    mapTo = "sbr_engine";
    diffuseMap[1] = "vehicles/sbr/sbr_engine_d.dds";
    specularMap[1] = "vehicles/sbr/sbr_engine_s.dds";
    normalMap[1] = "vehicles/sbr/sbr_engine_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/sbr/sbr_engine_n.dds";
    specularPower[0] = "32";
    pixelSpecular[0] = "1";
    specularPower[1] = "32";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    diffuseColor[1] = "1 1 1 1";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sbr_lights)
{
    mapTo = "sbr_lights";
    diffuseMap[1] = "vehicles/sbr/sbr_lights_d.dds";
    specularMap[1] = "vehicles/sbr/sbr_lights_s.dds";
    normalMap[1] = "vehicles/sbr/sbr_lights_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/sbr/sbr_lights_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sbr_lights_on)
{
    mapTo = "sbr_lights_on";
    diffuseMap[2] = "vehicles/sbr/sbr_lights_g.dds";
    specularMap[2] = "vehicles/sbr/sbr_lights_s.dds";
    normalMap[2] = "vehicles/sbr/sbr_lights_n.dds";
    diffuseMap[1] = "vehicles/sbr/sbr_lights_d.dds";
    specularMap[1] = "vehicles/sbr/sbr_lights_s.dds";
    normalMap[1] = "vehicles/sbr/sbr_lights_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/sbr/sbr_lights_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1.5 1.5 1.5 0.7";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    glow[2] = "1";
    emissive[2] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sbr_lights_on_intense)
{
    mapTo = "sbr_lights_on_intense";
    diffuseMap[2] = "vehicles/sbr/sbr_lights_g.dds";
    specularMap[2] = "vehicles/sbr/sbr_lights_s.dds";
    normalMap[2] = "vehicles/sbr/sbr_lights_n.dds";
    diffuseMap[1] = "vehicles/sbr/sbr_lights_d.dds";
    specularMap[1] = "vehicles/sbr/sbr_lights_s.dds";
    normalMap[1] = "vehicles/sbr/sbr_lights_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/sbr/sbr_lights_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    diffuseColor[2] = "1.5 1.5 1.5 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    useAnisotropic[2] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    dynamicCubemap = true;
    glow[2] = "1";
    emissive[2] = "1";
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sbr_lights_dmg)
{
    mapTo = "sbr_lights_dmg";
    diffuseMap[1] = "vehicles/sbr/sbr_lights_dmg_d.dds";
    specularMap[1] = "vehicles/sbr/sbr_lights_dmg_s.dds";
    normalMap[1] = "vehicles/sbr/sbr_lights_dmg_n.dds";
    diffuseMap[0] = "vehicles/common/null.dds";
    specularMap[0] = "vehicles/common/null.dds";
    normalMap[0] = "vehicles/sbr/sbr_lights_dmg_n.dds";
    specularPower[0] = "128";
    pixelSpecular[0] = "1";
    specularPower[1] = "128";
    pixelSpecular[1] = "1";
    diffuseColor[0] = "1 1 1 1";
    diffuseColor[1] = "1 1 1 1";
    useAnisotropic[0] = "1";
    useAnisotropic[1] = "1";
    castShadows = "1";
    translucent = "1";
    translucentBlendOp = "None";
    alphaTest = "0";
    alphaRef = "0";
    diffuseColor[1] = "1.5 1.5 1.5 1";
    dynamicCubemap = true;
    materialTag0 = "beamng"; materialTag1 = "vehicle";
};

singleton Material(sbr_reverselight)
{
    mapTo = "sbr_reverselight";
};

singleton Material(sbr_signal_R)
{
    mapTo = "sbr_signal_R";
};

singleton Material(sbr_signal_L)
{
    mapTo = "sbr_signal_L";
};

singleton Material(sbr_taillight_R)
{
    mapTo = "sbr_taillight_R";
};

singleton Material(sbr_taillight_L)
{
    mapTo = "sbr_taillight_L";
};

singleton Material(sbr_headlight)
{
    mapTo = "sbr_headlight";
};

singleton Material(sbr_runninglight)
{
    mapTo = "sbr_runninglight";
};

singleton Material(sbr_foglight)
{
    mapTo = "sbr_foglight";
};

singleton Material(sbr_chmsl)
{
    mapTo = "sbr_chmsl";
};

singleton Material(sbr_taillight)
{
    mapTo = "sbr_taillight";
};
