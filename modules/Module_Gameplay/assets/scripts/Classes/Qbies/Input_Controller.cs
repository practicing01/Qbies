function Class_Qbie_Input_Controller::onTouchDown(%this,%touchID,%Vector_2D_World_Position)
{

//echo(%this.Qbie_Parent.getIsPointInCollisionShape(%this.Qbie_Parent.Collision_Shape_Index,%Vector_2D_World_Position));//Bugged.

if (%this.Qbie_Parent.getIsPointInOOBB(%Vector_2D_World_Position))
{

if (Scene_Qbies.isJoint(%this.Qbie_Parent.Joint_Target_ID)&&%this.Qbie_Parent.Joint_Target_ID!=-1||!isObject(%this.Qbie_Parent))
{

return;

}

%this.Qbie_Parent.Joint_Target_ID=Scene_Qbies.createTargetJoint(%this.Qbie_Parent,%Vector_2D_World_Position,
%this.Qbie_Parent.Module_ID_Parent.Joint_Target_Max_Force,true,3,0,false);

}

}

function Class_Qbie_Input_Controller::onTouchUp(%this,%touchID,%Vector_2D_World_Position)
{

if (!Scene_Qbies.isJoint(%this.Qbie_Parent.Joint_Target_ID)&&%this.Qbie_Parent.Joint_Target_ID==-1||!isObject(%this.Qbie_Parent))
{

return;

}

Scene_Qbies.deleteJoint(%this.Qbie_Parent.Joint_Target_ID);

%this.Qbie_Parent.Joint_Target_ID=-1;

}

function Class_Qbie_Input_Controller::onTouchDragged(%this,%touchID,%Vector_2D_World_Position)
{

if (Scene_Qbies.isJoint(%this.Qbie_Parent.Joint_Target_ID)&&%this.Qbie_Parent.Joint_Target_ID!=-1&&isObject(%this.Qbie_Parent))
{

Scene_Qbies.setTargetJointTarget(%this.Qbie_Parent.Joint_Target_ID,%Vector_2D_World_Position);

}

}
