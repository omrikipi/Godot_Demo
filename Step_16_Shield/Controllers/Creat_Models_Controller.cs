using System.Linq;
using Godot;
using Interfaces;
using Messages;
using Models;
using Resources;

namespace Controllers;

public class Creat_Models_Controller
{
    public Creat_Models_Controller()
    {
        Create_Entity_Model_Request.Handler = Create_Entity_Model_Request_Handler;
    }

    private IEntity_Model Create_Entity_Model_Request_Handler(Create_Entity_Model_Request request)
    {
        var entity = new Entity_Model(request.Resource);
        entity.Actions.AddRange(request.Resource.Actions
                 .Select(r => Create_Action_Model(r, entity)));
        return entity;
    }

    private IAction_Model Create_Action_Model(Resource resource, IEntity_Model model)
    {
        if (resource is Dot_Resource)
            return new Dot_Model(model, resource as Dot_Resource);
        if (resource is Attack_Resource)
            return new Attack_Model(model, resource as Attack_Resource);
        if (resource is Hot_Resource)
            return new Hot_Model(model, resource as Hot_Resource);
        if (resource is Heal_Resource)
            return new Heal_Model(model, resource as Heal_Resource);
        if (resource is Shield_Resource)
            return new Shield_Model(model, resource as Shield_Resource);
        return null;
    }
}