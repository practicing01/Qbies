function Module_Gameplay::Scene_Initialize(%this)
{

exec("./Initialize/Walls_Initialize.cs");
exec("./Initialize/Triangles_Initialize.cs");
exec("./Initialize/Qbies_Initialize.cs");
exec("./Initialize/Score_Initialize.cs");
exec("./Initialize/Goal_Initialize.cs");
exec("./Initialize/Star_Initialize.cs");

%this.Walls_Initialize();

%this.Triangles_Initialize();

%this.Qbies_Initialize();

%this.Score_Initialize();

%this.Goal_Initialize();

%this.Star_Initialize();

//Scene_Qbies.setVelocityIterations(Scene_Qbies.getVelocityIterations()+4);

//Scene_Qbies.setPositionIterations(Scene_Qbies.getPositionIterations()+4);

}
