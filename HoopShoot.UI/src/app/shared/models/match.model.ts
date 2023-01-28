export class Match {
    constructor(
        public id: number,
        public homeTeamId: number,
        public homeTeam: string,
        public awayTeamId: number,
        public awayTeam: string,
        public awayTeamScore: number, 
        public homeTeamScore:number) {
    }
}