import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, FormControl } from '@angular/forms';
import { analyzers } from 'src/global/analyzers';
import { Analyzer } from 'src/models/analyzer';
import { AnalyzeRequest } from 'src/models/analyze-request';
import { AnalyzeResponse } from 'src/models/analyze-response';
import { AnalyzeService } from 'src/services/analyze.service';

@Component({
  selector: 'app-analyzer',
  templateUrl: './analyzer.component.html',
  styleUrls: ['./analyzer.component.css']
})
export class AnalyzerComponent implements OnInit {

  form: FormGroup;
  analyzers: Analyzer[];
  formAnalyzers: FormArray;
  response: AnalyzeResponse[];
  hasError: boolean;

  constructor(private readonly fb: FormBuilder,
              private readonly aService: AnalyzeService) { }

  ngOnInit() {
    this.analyzers = analyzers;
    this.formAnalyzers = new FormArray(this.analyzers.map(() => new FormControl(false)))

    this.form = this.fb.group({
      text: this.fb.control(''),
      analyzers: this.formAnalyzers
    });
  }

  onSubmit(): void {
    this.hasError = false;
    const selected = this.form.value.analyzers
    .map((checked, index) => checked ? this.analyzers[index].serverName : null)
    .filter(value => value !== null);

    const request: AnalyzeRequest = {
      text: this.form.value.text,
      analyzers: selected
    }

    this.aService.analyzeText(request).subscribe(
      response => this.response = response.body,
      error => {
        console.error(error);
        this.hasError = true;
      });
  }

}
