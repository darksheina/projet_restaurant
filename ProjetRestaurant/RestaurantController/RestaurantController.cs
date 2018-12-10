using RestaurationModel;
using RestaurationView;
namespace RestaurationController
{
    public class RestaurantController {
        private RestaurantModel restaurantModel1;
        private RestaurantView restaurantView;

        public RestaurantController(RestaurantModel restaurantModel, RestaurationView.RestaurantView restaurantView) {
			
        }
		public void StartScenario() {
			
		}
		public void SpeedUp(ref int speedTime) {
			
		}
		public void Pause() {
			
		}
		public void Continue() {
			throw new System.Exception("Not implemented");
		}
		
		public void UpdateParameter() {
			throw new System.Exception("Not implemented");
		}

        public RestaurantModel RestaurantModel { get => RestaurantModel; set => RestaurantModel = value; }
        public RestaurantView RestaurantView { get => restaurantView; set => restaurantView = value; }
    }

}
