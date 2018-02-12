export class ChartData {
    GroupName: string;
    Data: {
        Name: string;
        Series: ChartSeria[]; 
    }
}

export class ChartSeria {
    Name: string;
    Value: number;
}