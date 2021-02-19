using DynamicData;
using NodeNetwork.Toolkit.ValueNode;
using NodeNetwork.ViewModels;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WolvenKit.WKitGlobal
{
    class NodeNetworkHelper
    {
        public enum ERXNodes
        {
            
     
           
            Deletion, // Placeholder for patching (Passes a signal if the player had a savegame at this place in the quest) 
         
            Section,
            Choise,
            Scene,
            EquipItem,         //EquipItem can equip or unequip items
            

            StartMinigame,
            TransformAnimator,
            Move,
            VehicleMove,
            Teleport,
            Save,

            Input, // IN_NODE
            Output, // OUT_NODE
            Switch, // Switch_Node
            Randomizer,
            CutControl,
            Phase,
            AND,
            XOR, // X 
            FlowControl,
            Hub,
            PauseCondition,
            Condition,

            Comment,
            Note,

            EventManager,
            JournalManager,
            AudioManager,
            CharacterAudioManager,
            WorkspotManager,  // 
            FXManager,
            SceneManager,
            GameManager,
            UIManager,
            AIManager, // AI manager node itself switches NPCs between Cinematic and Gameplay AI
            WorldDataManager,
            EntityManager,
            InteractiveObjectManager,
            RenderManager,
            TimeManager,
            ItemManager, //ItemManager can do all sorts of shit
            PhoneManager,
            SpawnManager,
            FactsManager,
            InterruptionManager,
            LookAtManager,
            CrowdManager,
            RewardManager,
            VoiceSetManager,
            VisionSystemManager,
            MapPinManager,
            CharacterManager,
            CombatManager,
            VehicleManager,
            AICommandsManager, //Immediate : with it we can set npcs to patrol, be on proper Follower AI or clear that follower ai






        }

        public enum NodeGroup
        {
            BehaviorControl,
            Camera,
            ComplexityManagement,
            FlowControl,
            GameSystemsControl,
            Gameplay,
            Logical,
            QuestLog,
            Scenes,
            Scripting
        }
     


        public class Node_Template
        {
            //  public string Name;
            //  public Color Color;
            //  public List<NodeType> Sockets = new List<NodeType>();

        }
    }



    public class CustomNode : NodeViewModel
    {
        public Color nodecolor;


        public CustomNode(
            string NodeName,
            Color NodeColor,
            string NodeDescription,
            string NodeFamily,



            List<ValueNodeInputViewModel<Type>> InputSockets,
            List<ValueNodeOutputViewModel<Type>> OutputSockets)
        {
            this.Name = NodeName;
            nodecolor = NodeColor;


            foreach (var InSocket in InputSockets)
            {
                this.Inputs.Add(InSocket);
            }


            foreach (var OutSocket in OutputSockets)
            {
                this.Outputs.Add(OutSocket);
            }


        }
    }



}
