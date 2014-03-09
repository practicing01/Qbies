function Window_Create_Qbies()
{

if (!isObject(Window_Qbies))
{

new SceneWindow(Window_Qbies);   

Window_Qbies.Profile=Gui_Profile_Window_Qbies;

Canvas.setContent(Window_Qbies);                     

}

Window_Qbies.stopCameraMove();
Window_Qbies.dismount();
Window_Qbies.setViewLimitOff();
Window_Qbies.setRenderGroups(Qbies.All_Bits);
Window_Qbies.setRenderLayers(Qbies.All_Bits);
Window_Qbies.setObjectInputEventGroupFilter(Qbies.All_Bits);
Window_Qbies.setObjectInputEventLayerFilter(Qbies.All_Bits);
Window_Qbies.setLockMouse(true);
Window_Qbies.setCameraPosition(0,0);
Window_Qbies.setCameraZoom(1);
Window_Qbies.setCameraAngle(0);

Qbies.Resolution=getRes();
%Y_Times_100=100*Qbies.Resolution.Y;
%Cam_Y=%Y_Times_100/Qbies.Resolution.X;

Window_Qbies.setCameraSize(100,%Cam_Y);

if (!isObject(Gui_Qbies_Overlay))
{

new GuiControl(Gui_Qbies_Overlay)
{

Position="0 0";
Extent=Qbies.Resolution;
Profile=gui_profile_modalless;

};   

Window_Qbies.addGuiControl(Gui_Qbies_Overlay);

Gui_Qbies_Overlay.setActive(true);

}

}

//-----------------------------------------------------------------------------

function Window_Destroy_Qbies()
{
    
if (isObject(Window_Qbies))
{

Window_Qbies.delete();

}

}

//-----------------------------------------------------------------------------

function Scene_Destroy_Qbies()
{

if (isObject(Scene_Qbies))
{

Scene_Qbies.delete();

}

}

function Scene_Set_To_Window()
{

if (!isObject(Scene_Qbies))
{

error("Cannot set Qbies Scene to Window as the Scene is invalid.");
return;

}
    
Window_Qbies.setScene(Scene_Qbies);

Window_Qbies.stopCameraMove();
Window_Qbies.dismount();
Window_Qbies.setViewLimitOff();
Window_Qbies.setRenderGroups(Qbies.All_Bits);
Window_Qbies.setRenderLayers(Qbies.All_Bits);
Window_Qbies.setObjectInputEventGroupFilter(Qbies.All_Bits);
Window_Qbies.setObjectInputEventLayerFilter(Qbies.All_Bits);
Window_Qbies.setLockMouse(true);
Window_Qbies.setCameraPosition(0,0);
Window_Qbies.setCameraZoom(1);
Window_Qbies.setCameraAngle(0);

Qbies.Resolution=getRes();
%Y_Times_100=100*Qbies.Resolution.Y;
%Cam_Y=%Y_Times_100/Qbies.Resolution.X;

Window_Qbies.setCameraSize(100,%Cam_Y);

}

function Scene_Create_Qbies()
{

Scene_Destroy_Qbies();

new Scene(Scene_Qbies);

if (!isObject(Window_Qbies))
{

error("Qbies: Created scene but no window available.");
return;

}

Scene_Set_To_Window();    
}

function Scene_Set_Custom(%Scene)
{

if (!isObject(%Scene))
{

error("Cannot set Qbies to use an invalid Scene.");
return;

}
   
Scene_Destroy_Qbies();

%Scene.setName("Scene_Qbies");

//%Scene.class="Class_Scene_Qbies";

Scene_Set_To_Window();

//%Scene.setDebugOn("joints");
//%Scene.setDebugOn("metrics");
//%Scene.setDebugOn("fps");
//%Scene.setDebugOn("wireframe");
//%Scene.setDebugOn("aabb");
//%Scene.setDebugOn("oobb");
//%Scene.setDebugOn("sleep");
//%Scene.setDebugOn("collision");
//%Scene.setDebugOn("position");
//%Scene.setDebugOn("sort");
//%Scene.setDebugOn("controllers");

}

//-----------------------------------------------------------------------------

/*function Class_Scene_Qbies::onSceneCollision(%this,%Scene_Object_0,%Scene_Object_1,%Collision_Details)
{

echo(%Scene_Object_0.class);

echo(%Scene_Object_1.class);

}*/
