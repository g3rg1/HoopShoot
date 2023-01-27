export class Match {
    constructor(
        public Id: number,
        public HomeTeamId: number,
        public HomeTeam: string,
        public AwayTeamId: number,
        public AwayTeam: string,
        public AwayTeamScore: number, 
        public HomeTeamScore:number) {
    }
}