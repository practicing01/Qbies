function Class_Qbie::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Qbie")
{

%ScriptObject_Qbies_Connected=new ScriptObject()
{

Sprite_Qbie=%Colliding_Object;

Joint_Distance_ID=-1;

};

%ScriptObject_Qbies_Connected.Joint_Distance_ID=Scene_Qbies.createDistanceJoint(%this,%Colliding_Object,"0 0","0 0",
Vector2Distance(%this.Position,%Colliding_Object.Position),
%this.Module_ID_Parent.Joint_Distance_Frequency,
%this.Module_ID_Parent.Joint_Distance_Damping_Ratio,
false);

%this.Simset_Qbies_Connected.add(%ScriptObject_Qbies_Connected);

if (%Colliding_Object==%this.Module_ID_Parent.Sprite_Qbie_Player)
{

%this.Bool_Connected_To_Qbie_Player=true;

if (!%this.Module_ID_Parent.Simset_Qbies_Connected_To_Player.isMember(%this))
{

%this.Module_ID_Parent.Simset_Qbies_Connected_To_Player.add(%this);

}

}

}

}
