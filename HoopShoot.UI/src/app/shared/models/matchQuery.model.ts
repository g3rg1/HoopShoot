export class MatchQuery {
    constructor(
        public queryScore: number,
        public Id: number,
        public homeTeamId: number,
        public homeTeam: string,
        public awayTeamId: number,
        public awayTeam: string,
        public awayTeamScore: number, 
        public homeTeamScore:number) {
    }
}