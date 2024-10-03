# Inference and Fine-tuning LLM models locally

## Overview

This project provides a guide on how to run and fine-tune Large Language Models (LLMs) locally using ONNX Runtime. It also covers inferencing and how to set up a local development environment for these models.

## Prerequisites

- Install the **AI Toolkit** extension for Visual Studio Code:
  [AI Toolkit Documentation](https://learn.microsoft.com/en-us/windows/ai/toolkit/)
- Install .NET 8.0 SDK:
  [Download .NET SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Sources

- [Hugging Face models](https://huggingface.co/models) 
- [ONNX Runtime](https://onnxruntime.ai/)
- [ONXX Runtime Docs](https://onnxruntime.ai/docs/)
- [ONNX tutorials](https://github.com/onnx/tutorials?tab=readme-ov-file)
- [ONNX introduction](https://www.youtube.com/watch?v=Ij5MoUnLQ0E)
- [ONNX on-device training](https://www.youtube.com/watch?v=XNBaIpcS9rg)
- [ONNX with Phi](https://www.youtube.com/watch?v=WLW4SE8M9i8)
- [ONNX Cookbook](https://github.com/microsoft/Phi-3CookBook?tab=readme-ov-file)

## Roadmap

- [x] Downloading models in ONNX format
- [x] Running models locally
- [ ] Inferencing LLM models with Open AI API
- [ ] Inferencing LLM models with ONNX Runtime
- [ ] Fine-tuning LLM models
- [ ] Fine-tuning pipelines

## Setting up environment

To run models locally, you can use the ONNX framework, which allows models trained in various frameworks (like PyTorch, TensorFlow) to be exported and run independently. ONNX optimizes performance, making it possible to run even complex models efficiently on limited hardware.

### Why use ONNX?

- **Cross-platform**: Run models on a wide range of devices (Windows, macOS, Linux).
- **Hardware acceleration**: Utilize CPU, GPU, or specialized accelerators.
- **Optimized for inferencing**: ONNX is specifically optimized for fast inferencing, making it ideal for production environments.

### 1. Install ONNX Runtime:

For **macOS** (via Homebrew):

```bash
brew install onnxruntime
```

For **Windows** or **Linux**, you can download the appropriate runtime from the [ONNX Runtime releases](https://github.com/microsoft/onnxruntime/releases).

### 2. Download an LLM Model in ONNX Format:

You can download models from Hugging Face or export your custom-trained models into ONNX format.

Example command to download:

```bash
huggingface-cli download microsoft/Phi-3-mini-128k-cpu-int4-rtn-block-32-onnx --local-dir models/
```

### 3. Run an ONNX Model:

We can run the model using AI Toolkit in VS Code or by using the ONNX runtime command-line interface.

#### Using AI Toolkit:

1. Open the model in Visual Studio Code.

## Inference

We cna use Open AI API to ONNX Runtime to inference LLM models locally.

### 1. Inferencing LLM models with Open AI API

[This project](src/Models.Inferencing/Models.Inferencing.csproj) is an example of how to use the Open AI API to inference LLM models.


## Fine-tuning

For instructions on fine-tuning models, see [Fine-tuning Documentation](docs/fine-tuning.md).