import { Component, Input, OnInit } from '@angular/core';
import { ConvertResult } from '../models/convert-result'

@Component({
  selector: 'app-result-label',
  templateUrl: './result-label.component.html',
  styleUrls: ['./result-label.component.css']
})
export class ResultLabelComponent implements OnInit {

  constructor() { }

  @Input() convertResult: ConvertResult = new ConvertResult("")

  ngOnInit(): void {
  }

}
