import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {

  private API: string = "http://localhost:5000";

  exams: Array<any> = [];
  displayedColumns: Array<string> = ['semester', 'classe', 'grade', 'aprovacao'];

  constructor(private http: HttpClient) {
  }

  tabChange($event: any) {
    if ($event.index === 1) {
      this.http.get<any>(`${this.API}/exam`).subscribe(exams => {
        this.exams = exams;
      });
    }
  }
}
