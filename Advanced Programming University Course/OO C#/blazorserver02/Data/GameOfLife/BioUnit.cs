namespace blazorserver02.Data.GameOfLife
{
    public class BioUnit
    {
        private bool alive; 
        public BioUnit(bool alive=false) {
            this.alive = alive;
        }
        public bool is_alive() {
            return this.alive;
        }
        public bool is_dead() {
            return !this.alive;
        }
        public void live() {
            this.alive = true;
        }
        public void die() {
            this.alive = false;
        }
    }
}