using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    // Player Attributes
    public string playerName;
    public int calories;
    public int carbohydrates;
    public int proteins;
    public int fats;
    public int micronutrients;

    public int foodCount;
    public int flag;
    public bool missionCompleted;

    // Player nutrients scoreText
    public Text caloriesScore;
    public Text carbohydratesScore;
    public Text proteinsScore;
    public Text fatsScore;
    public Text micronutrientsScore;
    
    // GUI
    public GameObject graphicUI;

    public GameObject carbohydratesWindow;
    public GameObject proteinsWindow;
    public GameObject fatsWindow;
    public GameObject micronutrientsWindow;

    // Missions
    public GameObject missionCarbohydrates;
    public GameObject missionProteins;
    public GameObject missionFats;
    public GameObject missionMicronutrients;

    // Inventory Icons
    public GameObject bananaIcon;
    public GameObject toastIcon;
    public GameObject riceIcon;
    public GameObject breadIcon;
    public GameObject chickenIcon;
    public GameObject eggIcon;
    public GameObject steakIcon;
    public GameObject cheeseIcon;
    public GameObject avocadoIcon;
    public GameObject fishIcon;
    public GameObject eggfatsIcon;
    public GameObject tomatoIcon;
    public GameObject lettuceIcon;
    public GameObject pineappleIcon;
    public GameObject watermelonIcon;
    public GameObject sweetpepperIcon;
    public GameObject onionIcon;

    // Food objects
    public GameObject banana;
    public GameObject toast;
    public GameObject rice;
    public GameObject bread;
    public GameObject chicken;
    public GameObject egg;
    public GameObject steak;
    public GameObject cheese;
    public GameObject avocado;
    public GameObject fish;
    public GameObject eggfats;
    public GameObject tomato;
    public GameObject lettuce;
    public GameObject pineapple;
    public GameObject watermelon;
    public GameObject sweetpepper;
    public GameObject onion;

    // Player Save and Load Methods
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        playerName = data.playerName;
        calories = data.calories;
        carbohydrates = data.carbohydrates;
        proteins = data.proteins;
        fats = data.fats;
        
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;

        missionCompleted = data.missionCompleted;

    }

    // Methods to define Player behaviour when collision occurs.
    void OnTriggerEnter(Collider objeto)
    {
        if (objeto.gameObject.name == "Banana")
        {
            bananaIcon.gameObject.SetActive(true);
            carbohydrates = carbohydrates + 25;
        }

        if (objeto.gameObject.name == "Toast")
        {
            toastIcon.gameObject.SetActive(true);
            carbohydrates = carbohydrates + 25;
        }

        if (objeto.gameObject.name == "Rice")
        {
            riceIcon.gameObject.SetActive(true);
            carbohydrates = carbohydrates + 25;
        }

        if (objeto.gameObject.name == "Bread")
        {
            breadIcon.gameObject.SetActive(true);
            carbohydrates = carbohydrates + 25;
        }

        if (objeto.gameObject.name == "Chicken")
        {
            chickenIcon.gameObject.SetActive(true);
            proteins = proteins + 25;
        }

        if (objeto.gameObject.name == "Egg")
        {
            eggIcon.gameObject.SetActive(true);
            proteins = proteins + 25;
        }

        if (objeto.gameObject.name == "Steak")
        {
            steakIcon.gameObject.SetActive(true);
            proteins = proteins + 25;
        }

        if (objeto.gameObject.name == "Cheese")
        {
            cheeseIcon.gameObject.SetActive(true);
            proteins = proteins + 25;
        }

        if (objeto.gameObject.name == "Avocado")
        {
            avocadoIcon.gameObject.SetActive(true);
            fats = fats + 35;
        }

        if (objeto.gameObject.name == "Fish")
        {
            fishIcon.gameObject.SetActive(true);
            fats = fats + 30;
        }

        if (objeto.gameObject.name == "EggFats")
        {
            eggfatsIcon.gameObject.SetActive(true);
            fats = fats + 35;
        }

        if (objeto.gameObject.name == "Tomato")
        {
            tomatoIcon.gameObject.SetActive(true);
            micronutrients = micronutrients + 15;
        }

        if (objeto.gameObject.name == "Lettuce")
        {
            lettuceIcon.gameObject.SetActive(true);
            micronutrients = micronutrients + 17;
        }

        if (objeto.gameObject.name == "Pineapple")
        {
            pineappleIcon.gameObject.SetActive(true);
            micronutrients = micronutrients + 17;
        }

        if (objeto.gameObject.name == "Watermelon")
        {
            watermelonIcon.gameObject.SetActive(true);
            micronutrients = micronutrients + 17;
        }

        if (objeto.gameObject.name == "SweetPepper")
        {
            sweetpepperIcon.gameObject.SetActive(true);
            micronutrients = micronutrients + 17;
        }

        if (objeto.gameObject.name == "Onion")
        {
            onionIcon.gameObject.SetActive(true);
            micronutrients = micronutrients + 17;
        }

        foodCount = foodCount + 1;
        flag = flag + 1;
        objeto.gameObject.SetActive(false);
     
    }

    // Start is called before the first frame update
    void Start()
    {
        // Desactivates de further missions
        missionProteins.gameObject.SetActive(false);
        missionFats.gameObject.SetActive(false);
        missionMicronutrients.gameObject.SetActive(false);

        // Desactivates food icons (inventory) at the start of the game.
        bananaIcon.gameObject.SetActive(false);
        toastIcon.gameObject.SetActive(false);
        riceIcon.gameObject.SetActive(false);
        breadIcon.gameObject.SetActive(false);
        chickenIcon.gameObject.SetActive(false);
        eggIcon.gameObject.SetActive(false);
        steakIcon.gameObject.SetActive(false);
        cheeseIcon.gameObject.SetActive(false);
        avocadoIcon.gameObject.SetActive(false);
        fishIcon.gameObject.SetActive(false);
        eggfatsIcon.gameObject.SetActive(false);
        tomatoIcon.gameObject.SetActive(false);
        lettuceIcon.gameObject.SetActive(false);
        pineappleIcon.gameObject.SetActive(false);
        watermelonIcon.gameObject.SetActive(false);
        sweetpepperIcon.gameObject.SetActive(false);  
        onionIcon.gameObject.SetActive(false);

        // Desactivates food objects refered to advanced missions
        chicken.gameObject.SetActive(false);
        egg.gameObject.SetActive(false);
        steak.gameObject.SetActive(false);
        cheese.gameObject.SetActive(false);
        avocado.gameObject.SetActive(false);
        fish.gameObject.SetActive(false);
        eggfats.gameObject.SetActive(false);
        tomato.gameObject.SetActive(false);
        lettuce.gameObject.SetActive(false);
        pineapple.gameObject.SetActive(false);
        watermelon.gameObject.SetActive(false);
        sweetpepper.gameObject.SetActive(false);
        onion.gameObject.SetActive(false);

        // Set the initial state of the player
        calories = 0;
        carbohydrates = 0;
        proteins = 0;
        fats = 0;

        foodCount = 0;
        flag = 0;
        missionCompleted = false;
            
    }

    // Update is called once per frame
    void Update()
    {

        // Score update
        caloriesScore.text = "Kilocalorías: " + calories;
        carbohydratesScore.text = "Carbohidratos: " + carbohydrates;
        proteinsScore.text = "Proteínas: " + proteins;
        fatsScore.text = "Grasas saludables: " + fats;
        micronutrientsScore.text = "Micronutrientes: " + micronutrients;

        // Show Inventory GUI
        if (Input.GetKey("tab")){
            graphicUI.gameObject.SetActive(true);
        }
        else
        {
            graphicUI.gameObject.SetActive(false);
        }

        // Flag to manage advices
        if (flag == 4)
        {
            carbohydratesWindow.gameObject.SetActive(true);
            flag = flag + 1;
        }

        if (flag == 9)
        {
            proteinsWindow.gameObject.SetActive(true);
            flag = flag + 1;
        }

        if (flag == 13)
        {
            fatsWindow.gameObject.SetActive(true);
            flag = flag + 1;
        }

        if (flag == 20)
        {
            micronutrientsWindow.SetActive(true);
            flag = flag + 1;
        } 
        
        // Activates 2nd mission
        if (foodCount == 4)
        {
            missionCarbohydrates.gameObject.SetActive(false);
            missionProteins.gameObject.SetActive(true);

            chicken.gameObject.SetActive(true);
            egg.gameObject.SetActive(true);
            steak.gameObject.SetActive(true);
            cheese.gameObject.SetActive(true);
                                 
        }

        // Activates 3rd mission
        if (foodCount == 8)
        {
            missionProteins.gameObject.SetActive(false);
            missionFats.gameObject.SetActive(true);

            avocado.gameObject.SetActive(true);
            fish.gameObject.SetActive(true);
            eggfats.gameObject.SetActive(true);
          
        }

        // Activates 4th mission
        if (foodCount == 11)
        {
            missionFats.gameObject.SetActive(false);
            missionMicronutrients.gameObject.SetActive(true);

            tomato.gameObject.SetActive(true);
            lettuce.gameObject.SetActive(true);
            pineapple.gameObject.SetActive(true);
            watermelon.gameObject.SetActive(true);
            sweetpepper.gameObject.SetActive(true);
            onion.gameObject.SetActive(true);
            
        }

        // Set mission completed to True and show final message
        if (foodCount == 17)
        {
            missionMicronutrients.gameObject.SetActive(false);
            missionCompleted = true;
        }

        if (missionCompleted == true)
        {
            banana.gameObject.SetActive(false);
            toast.gameObject.SetActive(false);
            rice.gameObject.SetActive(false);
            bread.gameObject.SetActive(false);
            chicken.gameObject.SetActive(false);
            egg.gameObject.SetActive(false);
            steak.gameObject.SetActive(false);
            cheese.gameObject.SetActive(false);
            avocado.gameObject.SetActive(false);
            fish.gameObject.SetActive(false);
            eggfats.gameObject.SetActive(false);
            tomato.gameObject.SetActive(false);
            lettuce.gameObject.SetActive(false);
            pineapple.gameObject.SetActive(false);
            watermelon.gameObject.SetActive(false);
            sweetpepper.gameObject.SetActive(false);
            onion.gameObject.SetActive(false);
        }

    }
}

