/**
* <author>Warped ibun</author>
* <email>lifxmod@gmail.com</email>
* <url>lifxmod.com</url>
* <credits>Christophe Roblin <christophe@roblin.no> modification to make it yolauncher server modpack and lifxcompatible</credits>
* <description>Bear Knools from mmo introduced to Lif:YO</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/

if (!isObject(LiFxLargeTanningtub))
{
    new ScriptObject(LiFxLargeTanningtub)
    {
    };
}
package LiFxLargeTanningtub
{
  function LiFxLargeTanningtub::setup() {
    LiFx::registerCallback($LiFx::hooks::onMaterialsLoad, RegisterMaterials, LiFxLargeTanningtub);

  }
  function LiFxLargeTanningtub::RegisterMaterials() {
    LiFx::loadRecursivelyInFolder("yolauncher/modpack/mods/LiFx/BigTub", "TubMaterials.cs");
  }
  function LiFxLargeTanningtub::path() {
    return $Con::File;
  }
};
activatePackage(LiFxLargeTanningtub);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxLargeTanningtub);